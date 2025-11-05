namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoSamlProviderQueryExecutorSchema

	/// <exclude/>
	public class SsoSamlProviderQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoSamlProviderQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoSamlProviderQueryExecutorSchema(SsoSamlProviderQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d060c889-2aac-495e-a695-19e1de3d1510");
			Name = "SsoSamlProviderQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5aa7639-5b66-4d72-9308-0563d89b2353");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,193,78,195,48,12,61,119,210,254,193,42,151,86,154,250,1,69,92,54,134,180,11,12,21,184,32,14,89,234,150,72,105,82,57,9,162,170,248,119,220,150,105,42,176,221,236,151,231,231,247,28,35,26,116,173,144,8,79,72,36,156,173,124,182,177,166,82,117,32,225,149,53,89,225,108,129,222,43,83,187,229,162,95,46,162,224,184,158,209,9,175,207,224,217,214,120,229,21,186,179,132,59,33,189,165,137,193,156,43,194,154,183,194,70,11,231,114,224,229,15,45,154,93,185,39,251,161,74,164,199,128,212,109,63,81,6,158,26,39,94,111,177,18,65,251,181,50,37,235,39,190,107,209,86,201,110,220,220,21,242,29,27,49,155,74,87,112,207,169,225,6,226,33,155,104,244,191,226,113,250,198,234,202,120,36,35,52,200,193,16,92,26,128,28,214,194,33,83,94,20,249,32,244,241,108,191,60,71,253,232,251,20,213,26,231,41,12,103,224,196,251,112,208,74,78,140,118,172,47,46,77,158,29,18,43,24,148,195,111,65,152,181,233,160,18,229,112,96,95,201,252,105,245,39,125,124,130,142,206,227,20,250,175,31,183,104,202,201,240,216,79,232,28,100,236,27,235,155,5,16,79,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d060c889-2aac-495e-a695-19e1de3d1510"));
		}

		#endregion

	}

	#endregion

}

