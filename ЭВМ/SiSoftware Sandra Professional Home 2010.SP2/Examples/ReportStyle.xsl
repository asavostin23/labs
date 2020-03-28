<?xml version="1.0"?>
<HTML xmlns:xsl="http://www.w3.org/TR/WD-xsl">

<BODY>

<xsl:for-each select="TModule">
  <h2><xsl:value-of select="Name"/></h2>

  <xsl:for-each select="TClass">
    <h3><xsl:value-of select="Name"/></h3>

    <xsl:for-each select="TDevice">
      <h3><xsl:value-of select="Name"/></h3>

      <xsl:for-each select="TItemGroup">
        <h4><xsl:value-of select="Name"/></h4>

        <xsl:for-each select="TItem">
          <DIV CLASS="field"><xsl:value-of select="Name"/> : <xsl:value-of select="DataValue"/></DIV>
        </xsl:for-each>

      </xsl:for-each>
    </xsl:for-each>
  </xsl:for-each>

  <xsl:for-each select="TDevice">
    <h3><xsl:value-of select="Name"/></h3>

    <xsl:for-each select="TItemGroup">
      <h4><xsl:value-of select="Name"/></h4>

      <xsl:for-each select="TItem">
        <DIV CLASS="field"><xsl:value-of select="Name"/> : <xsl:value-of select="DataValue"/></DIV>
      </xsl:for-each>

    </xsl:for-each>
  </xsl:for-each>

  <xsl:for-each select="TItemGroup">
    <h4><xsl:value-of select="Name"/></h4>

    <xsl:for-each select="TItem">
      <DIV CLASS="field"><xsl:value-of select="Name"/> : <xsl:value-of select="DataValue"/></DIV>
    </xsl:for-each>

  </xsl:for-each>

  <xsl:for-each select="TItem">
      <DIV CLASS="field"><xsl:value-of select="Name"/> : <xsl:value-of select="DataValue"/></DIV>
  </xsl:for-each>

</xsl:for-each>


</BODY>
</HTML>