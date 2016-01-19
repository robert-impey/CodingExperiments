<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output indent="yes" />
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()" />
		</xsl:copy>
	</xsl:template>

	<xsl:template match="/fruits">
		<xsl:copy>
			<xsl:apply-templates select="fruits"/>
			<xsl:apply-templates select="document('./AFruits.xml')/fruits/fruit" />
			<xsl:apply-templates select="document('./BFruits.xml')/fruits/fruit" />
			<xsl:apply-templates select="document('./CFruits.xml')/fruits/fruit" />
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>