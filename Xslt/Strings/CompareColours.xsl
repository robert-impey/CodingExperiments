<xsl:stylesheet version="2.0" 
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:foo="http://whatever">

	<!-- Using code from http://www.xml.com/pub/a/2003/09/03/trxml.html -->
  
	<!-- Compare two strings ignoring case, returning same
       values as compare(). -->
	<xsl:function name="foo:compareCI">
		<xsl:param name="string1"/>
		<xsl:param name="string2"/>
		<xsl:value-of select="compare(upper-case($string1),upper-case($string2))"/>
	</xsl:function>

	<xsl:template match="/colours">
		<colours>
			<xsl:for-each select="colour">
				<colour>
					<left>
						<xsl:value-of select="left" />
					</left>
					<right>
						<xsl:value-of select="right" />
					</right>
					<comparison>
						<xsl:value-of select="foo:compareCI(left, right)"/>
					</comparison>
				</colour>
			</xsl:for-each>
		</colours>
	</xsl:template>


</xsl:stylesheet>