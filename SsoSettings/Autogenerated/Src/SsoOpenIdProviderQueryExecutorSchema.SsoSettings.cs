namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoOpenIdProviderQueryExecutorSchema

	/// <exclude/>
	public class SsoOpenIdProviderQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoOpenIdProviderQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoOpenIdProviderQueryExecutorSchema(SsoOpenIdProviderQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c5a8959-a182-473a-b083-85bc786758d3");
			Name = "SsoOpenIdProviderQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5aa7639-5b66-4d72-9308-0563d89b2353");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,78,195,48,12,61,119,210,254,193,42,151,86,154,250,1,69,92,54,134,180,11,12,13,184,32,14,89,234,150,72,157,83,57,9,162,170,248,119,220,150,9,138,24,187,217,47,207,239,61,59,164,14,232,26,165,17,30,144,89,57,91,250,108,101,169,52,85,96,229,141,165,108,231,236,14,189,55,84,185,249,172,155,207,162,224,164,158,208,25,47,79,224,217,154,188,241,6,221,73,194,141,210,222,242,200,16,206,5,99,37,174,176,170,149,115,57,136,249,93,131,180,41,182,108,223,76,129,124,31,144,219,245,59,234,32,83,195,196,243,53,150,42,212,126,105,168,16,253,196,183,13,218,50,217,12,206,237,78,191,226,65,77,166,210,5,220,202,214,112,5,241,255,242,113,250,34,250,134,60,50,169,26,116,31,233,76,34,200,97,169,28,10,233,201,176,15,170,62,158,238,87,238,168,27,178,127,175,107,201,121,14,253,41,100,235,109,216,215,70,143,140,102,168,207,216,38,143,14,89,52,8,117,255,103,16,38,109,218,235,68,57,236,37,89,50,125,90,252,113,131,248,39,120,204,31,167,208,125,124,101,70,42,198,216,67,63,162,83,80,176,79,151,177,22,23,89,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c5a8959-a182-473a-b083-85bc786758d3"));
		}

		#endregion

	}

	#endregion

}

