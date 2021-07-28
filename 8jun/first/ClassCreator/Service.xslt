<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="text" indent="yes"/>
	<xsl:template match="/">
		using KMISMEntities;
		using KMISMModels;
		using KMISMRepository;
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		using System.Threading.Tasks;

		namespace KMISMService
		{
		public class <xsl:value-of select="note/name"/>Service
		{

		public <xsl:value-of select="note/name"/>Repository <xsl:value-of select="note/name"/>Repository { get; set; }

		public <xsl:value-of select="note/name"/>Service(<xsl:value-of select="note/name"/>Repository <xsl:value-of select="note/name"/>Repository)
		{
		<xsl:value-of select="note/name"/>Repository = <xsl:value-of select="note/name"/>Repository;
		}
		public List&lt;<xsl:value-of select="note/name"/>&gt; GetAll<xsl:value-of select="note/name"/>s()
		{

		return <xsl:value-of select="note/name"/>Repository.GetAll<xsl:value-of select="note/name"/>s();
		}


		public <xsl:value-of select="note/name"/> Get<xsl:value-of select="note/name"/>ById(int id)
		{
		<xsl:value-of select="note/name"/> <xsl:value-of select="note/name"/> = <xsl:value-of select="note/name"/>Repository.Get<xsl:value-of select="note/name"/>ById(id);
		return  <xsl:value-of select="note/name"/>;
		}

		//public List&lt;<xsl:value-of select="note/name"/>&gt; Get<xsl:value-of select="note/name"/>s(<xsl:value-of select="note/name"/>SearchModel <xsl:value-of select="note/name"/>Search)
		//{
		//    var lst<xsl:value-of select="note/name"/>= <xsl:value-of select="note/name"/>Repository.Get<xsl:value-of select="note/name"/>s(<xsl:value-of select="note/name"/>Search);
		//    <xsl:value-of select="note/name"/>Repository.Bind<xsl:value-of select="note/name"/>(lst<xsl:value-of select="note/name"/>);
		//    return <xsl:value-of select="note/name"/>Repository.Get<xsl:value-of select="note/name"/>s(<xsl:value-of select="note/name"/>Search);
		//}
		}
		}

	</xsl:template>
</xsl:stylesheet>
