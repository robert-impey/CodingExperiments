<xsl:stylesheet version="1.0" 
 xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output indent="yes"/>

    <xsl:param name="pNewType" select="'Replacement'"/>

    <xsl:template match="node()|@*">
        <xsl:copy>
            <xsl:apply-templates select="node()|@*"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="property/@type[.='Replace me!']">
        <xsl:attribute name="type">
            <xsl:value-of select="$pNewType"/>
        </xsl:attribute>
    </xsl:template>
</xsl:stylesheet>