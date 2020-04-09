#include "pch.h"
#include "CMatrix.h"
#define PI 3.14
CMatrix::CMatrix()
{
	n_rows = 1;
	n_cols = 1;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = 0;
}

//-------------------------------------------------------------------------------
CMatrix::CMatrix(int Nrow, int Ncol)
// Nrow - число строк
// Ncol - число столбцов
{
	n_rows = Nrow;
	n_cols = Ncol;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = 0;
}

//---------------------------------------------------------------------------------
CMatrix::CMatrix(int Nrow)  //Вектор
// Nrow - число строк
{
	n_rows = Nrow;
	n_cols = 1;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = 0;
}
//---------------------------------------------------------------------------------
CMatrix::~CMatrix()
{
	for (int i = 0; i < n_rows; i++) delete array[i];
	delete array;
}

//---------------------------------------------------------------------------------
double& CMatrix::operator()(int i, int j)
// i - номер строки
// j - номер столбца
{
	if ((i > n_rows - 1) || (j > n_cols - 1))     //  проверка выхода за диапазон
	{
		TCHAR* error = _T("CMatrix::operator(int,int): выход индекса за границу диапазона ");
		MessageBox(NULL, error, _T("Ошибка"), MB_ICONSTOP);
		exit(1);
	}
	return array[i][j];
}

//---------------------------------------------------------------------------------
double& CMatrix::operator()(int i)
// i - номер строки для вектора
{
	if (n_cols > 1)     //  Число столбцов больше одного
	{
		wchar_t* error = L"CMatrix::operator(int): объект не вектор - число столбцов больше 1 ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	if (i > n_rows - 1)     //  проверка выхода за диапазон
	{
		TCHAR* error = TEXT("CMatrix::operator(int): выход индекса за границу диапазона ");
		MessageBox(NULL, error, TEXT("Ошибка"), MB_ICONSTOP);
		exit(1);
	}
	return array[i][0];
}
//---------------------------------------------------------------------------------
CMatrix CMatrix::operator-()
// Оператор -M
{
	CMatrix Temp(n_rows, n_cols);
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) Temp(i, j) = -array[i][j];
	return Temp;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::operator+(CMatrix& M)
// Оператор M1+M2
{
	int bb = (n_rows == M.rows()) && (n_cols == M.cols());
	if (!bb)
	{
		wchar_t* error = L"CMatrix::operator(+): несоответствие размерностей матриц ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	CMatrix Temp(*this);
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) Temp(i, j) += M(i, j);
	return Temp;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::operator-(CMatrix& M)
// Оператор M1-M2
{
	int bb = (n_rows == M.rows()) && (n_cols == M.cols());
	if (!bb)
	{
		wchar_t* error = L"CMatrix::operator(-): несоответствие размерностей матриц ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	CMatrix Temp(*this);
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) Temp(i, j) -= M(i, j);
	return Temp;
}
//---------------------------------------------------------------------------------
CMatrix CMatrix::operator*(CMatrix& M)
// Умножение на матрицу M
{
	double sum;
	int nn = M.rows();
	int mm = M.cols();
	CMatrix Temp(n_rows, mm);
	if (n_cols == nn)
	{
		for (int i = 0; i < n_rows; i++)
			for (int j = 0; j < mm; j++)
			{
				sum = 0;
				for (int k = 0; k < n_cols; k++) sum += (*this)(i, k) * M(k, j);
				Temp(i, j) = sum;
			}
	}
	else
	{
		TCHAR* error = TEXT("CMatrix::operator*: несоответствие размерностей матриц ");
		MessageBox(NULL, error, TEXT("Ошибка"), MB_ICONSTOP);
		exit(1);
	}
	return Temp;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::operator=(const CMatrix& M)
// Оператор присваивания M1=M
{
	if (this == &M) return *this;
	int nn = M.rows();
	int mm = M.cols();
	if ((n_rows == nn) && (n_cols == mm))
	{
		for (int i = 0; i < n_rows; i++)
			for (int j = 0; j < n_cols; j++) array[i][j] = M.array[i][j];
	}
	else   // для ошибки размерностей
	{
		TCHAR* error = TEXT("CMatrix::operator=: несоответствие размерностей матриц");
		MessageBox(NULL, error, TEXT("Ошибка"), MB_ICONSTOP);
		exit(1);
	}
	return *this;
}

//---------------------------------------------------------------------------------
CMatrix::CMatrix(const CMatrix& M) // Конструктор копирования
{
	n_rows = M.n_rows;
	n_cols = M.n_cols;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = M.array[i][j];
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::operator+(double x)
// Оператор M+x, где M - матрица, x - число
{
	CMatrix Temp(*this);
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) Temp(i, j) += x;
	return Temp;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::operator-(double x)
// Оператор M+x, где M - матрица, x - число
{
	CMatrix Temp(*this);
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) Temp(i, j) -= x;
	return Temp;
}



//---------------------------------------------------------------------------------
CMatrix CMatrix::Transp()
// Возвращает матрицу,транспонированную к (*this)
{
	CMatrix Temp(n_cols, n_rows);
	for (int i = 0; i < n_cols; i++)
		for (int j = 0; j < n_rows; j++) Temp(i, j) = array[j][i];
	return Temp;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::GetRow(int k)
// Возвращает строку матрицы по номеру k
{
	if (k > n_rows - 1)
	{
		wchar_t* error = L"CMatrix::GetRow(int k): параметр k превышает число строк ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	CMatrix M(1, n_cols);
	for (int i = 0; i < n_cols; i++)M(0, i) = (*this)(k, i);
	return M;
}
//---------------------------------------------------------------------------------
CMatrix CMatrix::GetRow(int k, int n, int m)
// Возвращает подстроку из строки матрицы с номером k
// n - номер первого элемента в строке
// m - номер последнего элемента в строке
{
	int b1 = (k >= 0) && (k < n_rows);
	int b2 = (n >= 0) && (n <= m);
	int b3 = (m >= 0) && (m < n_cols);
	int b4 = b1 && b2 && b3;
	if (!b4)
	{
		wchar_t* error = L"CMatrix::GetRow(int k,int n, int m):ошибка в параметрах ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	int nCols = m - n + 1;
	CMatrix M(1, nCols);
	for (int i = n; i <= m; i++)M(0, i - n) = (*this)(k, i);
	return M;
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::GetCol(int k)
// Возвращает столбец матрицы по номеру k
{
	if (k > n_cols - 1)
	{
		wchar_t* error = L"CMatrix::GetCol(int k): параметр k превышает число столбцов ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	CMatrix M(n_rows, 1);
	for (int i = 0; i < n_rows; i++)M(i, 0) = (*this)(i, k);
	return M;
}
//---------------------------------------------------------------------------------
CMatrix CMatrix::GetCol(int k, int n, int m)
// Возвращает подстолбец из столбца матрицы с номером k
// n - номер первого элемента в столбце
// m - номер последнего элемента в столбце
{
	int b1 = (k >= 0) && (k < n_cols);
	int b2 = (n >= 0) && (n <= m);
	int b3 = (m >= 0) && (m < n_rows);
	int b4 = b1 && b2 && b3;
	if (!b4)
	{
		wchar_t* error = L"CMatrix::GetCol(int k,int n, int m):ошибка в параметрах ";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	int nRows = m - n + 1;
	CMatrix M(nRows, 1);
	for (int i = n; i <= m; i++)M(i - n, 0) = (*this)(i, k);
	return M;
}
//---------------------------------------------------------------------------------
CMatrix CMatrix::RedimMatrix(int NewRow, int NewCol)
// Изменяет размер матрицы с уничтожением данных
// NewRow - новое число строк
// NewCol - новое число столбцов 
{
	for (int i = 0; i < n_rows; i++) delete array[i];
	delete array;
	n_rows = NewRow;
	n_cols = NewCol;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = 0;
	return (*this);
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::RedimData(int NewRow, int NewCol)
// Изменяет размер матрицы с сохранением данных, которые можно сохранить
// NewRow - новое число строк
// NewCol - новое число столбцов 
{
	CMatrix Temp = (*this);
	this->RedimMatrix(NewRow, NewCol);
	int min_rows = Temp.rows() < (*this).rows() ? Temp.rows() : (*this).rows();
	int min_cols = Temp.cols() < (*this).cols() ? Temp.cols() : (*this).cols();
	for (int i = 0; i < min_rows; i++)
		for (int j = 0; j < min_cols; j++) (*this)(i, j) = Temp(i, j);
	return (*this);
}


//---------------------------------------------------------------------------------
CMatrix CMatrix::RedimMatrix(int NewRow)
// Изменяет размер матрицы с уничтожением данных
// NewRow - новое число строк
// NewCol=1
{
	for (int i = 0; i < n_rows; i++) delete array[i];
	delete array;
	n_rows = NewRow;
	n_cols = 1;
	array = new double* [n_rows];
	for (int i = 0; i < n_rows; i++) array[i] = new double[n_cols];
	for (int i = 0; i < n_rows; i++)
		for (int j = 0; j < n_cols; j++) array[i][j] = 0;
	return (*this);
}

//---------------------------------------------------------------------------------
CMatrix CMatrix::RedimData(int NewRow)
// Изменяет размер матрицы с сохранением данных, которые можно сохранить
// NewRow - новое число строк
// NewCol=1
{
	CMatrix Temp = (*this);
	this->RedimMatrix(NewRow);
	int min_rows = Temp.rows() < (*this).rows() ? Temp.rows() : (*this).rows();
	for (int i = 0; i < min_rows; i++)(*this)(i) = Temp(i);
	return (*this);
}
//----------------------------------------------------------------------------------
double CMatrix::MaxElement()
// Максимальное значение элементов матрицы
{
	double max = (*this)(0, 0);
	for (int i = 0; i < (this->rows()); i++)
		for (int j = 0; j < (this->cols()); j++) if ((*this)(i, j) > max) max = (*this)(i, j);
	return max;
}

//----------------------------------------------------------------------------------
double CMatrix::MinElement()
// Минимальное значение элементов матрицы
{
	double min = (*this)(0, 0);
	for (int i = 0; i < (this->rows()); i++)
		for (int j = 0; j < (this->cols()); j++) if ((*this)(i, j) < min) min = (*this)(i, j);
	return min;
}

void PrintMatrix(CDC& dc, int x, int y, CMatrix& M)
{
	int x_start = x;
	CString  out = L"";
	for (int i = 0; i < M.rows(); i++)
	{
		for (int j = 0; j < M.cols(); j++)
		{

			out.Format(L"%.2lf", M(i, j));
			dc.TextOut(x, y, out);
			x += 50;
		}
		y += 40;
		x = x_start;
	}
}

void SetValueMatrix(CMatrix& M, double start_value)
{
	for (int i = 0; i < M.rows(); i++)
	{
		for (int j = 0; j < M.cols(); j++)
		{
			M(i, j) = start_value;
			start_value += 0.5;
		}
	}
}

void SetValueMatrixWithIncrement(CMatrix& M, double start_value, double increment)
{
	for (int i = 0; i < M.rows(); i++)
	{
		for (int j = 0; j < M.cols(); j++)
		{
			M(i, j) = start_value;
			start_value += increment;
		}
	}
}

CMatrix VectorMult(CMatrix& V1, CMatrix& V2)
{
	if (V1.cols() != V2.cols() )
		MessageBox(NULL, L"Векторное произведение невозможно ", L"Ошибка", MB_ICONSTOP);
	CMatrix result(3, 1);
	result(0, 0) = V1(1, 0) * V2(2, 0) - V1(2, 0) * V2(1, 0);
	result(1, 0) =-(V1(0, 0) * V2(2, 0) - V1(2, 0) * V2(0, 0));
	result(2, 0) = V1(0, 0) * V2(1, 0) - V1(1, 0) * V2(0, 0);
	return result;
}

double ScalarMult(CMatrix& V1, CMatrix& V2)
{
	if (V1.cols() != V2.cols() )
		MessageBox(NULL, L"Скалярное произведение векторов невозможно ", L"Ошибка", MB_ICONSTOP);
	double result = 0;
	for (int i =0 ; i < V1.rows(); i++)
	{
		result += (V1(i, 0) * V2(i, 0));
	}
	return result;
}

double ModVec(CMatrix& V1)
{
	double result=0;
	for (int i = 0; i < V1.rows(); i++)
	{
		result += V1(i,0)*V1(i,0);
	}
	return sqrt(result);
}

double CosV1V2(CMatrix& V1, CMatrix& V2)
{
	return ScalarMult(V1, V2) / (ModVec(V1) * ModVec(V2));
}

CMatrix sphericalToCartesian(CMatrix& point)
{

	double r = point(0),//радиус
		theta = point(1), // полярный угол
		phi = point(2); // азимутальный угол
	if (r < 0 || phi < 0 || phi > PI)
	{
		CString error = L"CMatrix sphericalToCartesian(CMatrix&): недопустимые аргументы";
		MessageBox(NULL, error, L"Ошибка", MB_ICONSTOP);
		exit(1);
	}
	CMatrix result(3);
	result(0) = r * sin(theta) * cos(phi);
	result(1) = r * sin(theta) * sin(phi);
	result(2) = r * cos(theta);
	return result;
}
