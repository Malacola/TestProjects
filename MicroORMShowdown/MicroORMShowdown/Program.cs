using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;
using Massive;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using PetaPoco;

namespace MicroORMShowdown
{
	class Program
	{
		static void Main(string[] args)
		{
			//var table = new PowerPlants();

			//var plants = table.All();

			var point = SqlGeography.Point(47.8315, -121.626, 4326);

			//var param = new SqlParameter("@point", point);
			//param.UdtTypeName = "geography";
			//param.SqlDbType = SqlDbType.Udt;

			////var plantsNearBy = table.All(where: "WHERE geom.STDistance(geom.STDistance(@point) < 25", args: param);

			//using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Spatial"].ConnectionString))
			//using (SqlCommand cmd = new SqlCommand("Select * from PowerPlants where geom.STDistance(@point) < 25 * 1609.344", conn))
			//{
			//    SqlParameter p = cmd.Parameters.Add("@point", sqlDbType: SqlDbType.Udt);
			//    p.UdtTypeName = "geography";

			//    SqlGeography geog = SqlGeography.Point(47.8315, -121.626, 4326);

			//    p.Value = geog;
			//    conn.Open();
			//    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
			//    {
			//        var result = reader.ToExpandoList();
			//    }
			//}

			var db = new PetaPoco.Database("Spatial");

			long count = db.ExecuteScalar<long>("SELECT Count(*) FROM PowerPlants");

			var a = db.SingleOrDefault<PowerPlant>("WHERE PLANT_ID = @0", 72712);

			var b = db.Fetch<PowerPlant>(@"SELECT * FROM PowerPlants where geom.STDistance(@0) < 25 * 1609.344", point);

			var x = db.Fetch<PowerPlant>(PetaPoco.Sql.Builder.Append("WHERE geom.STDistance(@point) < @miles * 1609.344", 
				new { point = point, miles = 50 }));
		}
	}

	public class PowerPlants : DynamicModel
	{
		public PowerPlants() : base("Spatial") { }

	}

	[PetaPoco.TableName("PowerPlants")]
	public class PowerPlant : SpatialEntity
	{
		public string PLANT_NAME { get; set; }
		public int PLANT_ID { get; set; }
		//public SqlGeography geom { get; set; }
	}

	public abstract class SpatialEntity
	{
		[Column("geom")]
		public SqlGeography Location { get; set; }
	}
}
