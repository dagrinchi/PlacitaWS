namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PlacitaWS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PlacitaWS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlacitaWS.Models.ApplicationDbContext context)
        {
            context.Units.AddOrUpdate(
                u => u.Code,
                new Unit { Code = "UND", Name = "Unidad" },
                new Unit { Code = "LIB", Name = "Libra" },
                new Unit { Code = "KLG", Name = "Kilogramo"},
                new Unit { Code = "BUL", Name = "Bulto" },
                new Unit { Code = "CAR", Name = "Carga" },
                new Unit { Code = "ARR", Name = "Arroba" }                
            );

            context.Products.AddOrUpdate(
                p => p.Code,
                new Product { Code = "1101", Name = "Aguacate" },
                new Product { Code = "1102", Name = "Banano" },
                new Product { Code = "1103", Name = "Ciruela" },
                new Product { Code = "1104", Name = "Coco" },
                new Product { Code = "1105", Name = "Curuba" },
                new Product { Code = "1106", Name = "Durazno" },
                new Product { Code = "1107", Name = "Feijoa" },
                new Product { Code = "1108", Name = "Granadilla" },
                new Product { Code = "1109", Name = "Guayaba" },
                new Product { Code = "1110", Name = "Gulupa" },
                new Product { Code = "1111", Name = "Limón" },
                new Product { Code = "1112", Name = "Lulo" },
                new Product { Code = "1113", Name = "Mandarina" },
                new Product { Code = "1114", Name = "Mango" },
                new Product { Code = "1115", Name = "Manzana" },
                new Product { Code = "1116", Name = "Maracuyá" },
                new Product { Code = "1117", Name = "Melón" },
                new Product { Code = "1118", Name = "Mora" },
                new Product { Code = "1119", Name = "Naranja" },
                new Product { Code = "1120", Name = "Papaya" },
                new Product { Code = "1121", Name = "Patilla" },
                new Product { Code = "1122", Name = "Pera" },
                new Product { Code = "1123", Name = "Piña" },
                new Product { Code = "1124", Name = "Tangelo y pomelo" },
                new Product { Code = "1125", Name = "Tomate de árbol" },
                new Product { Code = "1126", Name = "Uchuva" },
                new Product { Code = "1199", Name = "Otras frutas" },
                new Product { Code = "1201", Name = "Acelga" },
                new Product { Code = "1202", Name = "Ahuyama" },
                new Product { Code = "1203", Name = "Ajo" },
                new Product { Code = "1204", Name = "Arveja" },
                new Product { Code = "1205", Name = "Berenjena" },
                new Product { Code = "1206", Name = "Brócoli" },
                new Product { Code = "1207", Name = "Calabaza" },
                new Product { Code = "1208", Name = "Cebolla Cabezona" },
                new Product { Code = "1209", Name = "Cebolla Larga o Junca" },
                new Product { Code = "1210", Name = "Cilantro" },
                new Product { Code = "1211", Name = "Col" },
                new Product { Code = "1212", Name = "Coliflor" },
                new Product { Code = "1213", Name = "Espárrago" },
                new Product { Code = "1214", Name = "Espinaca" },
                new Product { Code = "1215", Name = "Fríjol" },
                new Product { Code = "1216", Name = "Haba" },
                new Product { Code = "1217", Name = "Habichuela" },
                new Product { Code = "1218", Name = "Lechuga" },
                new Product { Code = "1219", Name = "Pepino" },
                new Product { Code = "1220", Name = "Perejil" },
                new Product { Code = "1221", Name = "Pimenton" },
                new Product { Code = "1222", Name = "Puerro" },
                new Product { Code = "1223", Name = "Rábano" },
                new Product { Code = "1224", Name = "Remolacha" },
                new Product { Code = "1225", Name = "Repollo" },
                new Product { Code = "1226", Name = "Tomate" },
                new Product { Code = "1227", Name = "Zanahoria" },
                new Product { Code = "1299", Name = "Otras hortalizas" },
                new Product { Code = "1302", Name = "Arroz" },
                new Product { Code = "1303", Name = "Cebada" },
                new Product { Code = "1304", Name = "Maíz" },
                new Product { Code = "1305", Name = "Trigo" },
                new Product { Code = "1306", Name = "Sorgo" },
                new Product { Code = "1399", Name = "Otros cereales" },
                new Product { Code = "1401", Name = "Ñame" },
                new Product { Code = "1402", Name = "Papa" },
                new Product { Code = "1403", Name = "Plátano" },
                new Product { Code = "1404", Name = "Yuca" },
                new Product { Code = "1499", Name = "Otros tuberculos" },
                new Product { Code = "1501", Name = "Ajonjolí y otras oleaginosas" },
                new Product { Code = "1502", Name = "Algodón desmotado y semilla" },
                new Product { Code = "1503", Name = "Cacao en grano" },
                new Product { Code = "1504", Name = "Caña de azúcar" },
                new Product { Code = "1505", Name = "Caña de azúcar para panela y miel" },
                new Product { Code = "1506", Name = "Palma de Aceite" },
                new Product { Code = "1507", Name = "Soya" },
                new Product { Code = "1508", Name = "Tabaco" },
                new Product { Code = "1599", Name = "Otros productos agroindustriales" }       
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
