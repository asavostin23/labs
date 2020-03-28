/****************************************************************************
  FileName     [ knapsack.h ]
  Synopsis     [ Knapsack Solver ]
  Author       [ Jui-Yang (Tony) Hsu]
  Copyright    [ Copyleft(c) 2017 NTUEE, Taiwan ]
****************************************************************************/

#ifndef KNAPSACK_H
#define KNAPSACK_H

#include <vector>
#include <algorithm>
/**
 * Note: weight type must be integer
**/
namespace knapsack{
  struct Item{
    int value;
    int weight;

    Item(int value=0,int weight=0): value(value),weight(weight){}
  };
  
  //Given the item list (item w/ weight and value) and capacity constraint
  //Returns an integer vector representing the picked item's id of OPT soltion
  //DP[n,w]: max value of picked item (1 ~ n) s.t weight <= w
  std::vector<int> knapsack_solver(std::vector<Item>& item_ls, int cap){

    int num_item = item_ls.size();
    int DP[num_item+1][cap+1] = {};
    
    for(int n=1;n<=num_item;++n){ 
      for(int w=1;w<=cap;++w){
        if(w < item_ls[n-1].weight)
          DP[n][w] = DP[n-1][w];
        else
          DP[n][w] = std::max(DP[n-1][w],DP[n-1][w-item_ls[n-1].weight]+item_ls[n-1].value);
      }
    }

    std::vector<int> picked_items; picked_items.reserve(num_item);
    for(int n=num_item,w=cap;n>=1;--n){
      if(w-item_ls[n-1].weight >= 0 && (DP[n-1][w-item_ls[n-1].weight] + item_ls[n-1].value== DP[n][w])){
        picked_items.push_back(n-1);
        w -= item_ls[n-1].weight;
      }
    }
    return picked_items;
  }
}
#endif
