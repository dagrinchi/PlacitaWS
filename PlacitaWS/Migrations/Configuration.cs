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
            context.OrderStatus.AddOrUpdate(
                os => os.Id,
                new OrderStatus { Id = 1, Status = "CONTACTO", Farmer = false, Buyer = false, Color = "#0198e1" },
                new OrderStatus { Id = 2, Status = "TRASPORTE", Farmer = true, Buyer = false, Color = "#ff8600" },
                new OrderStatus { Id = 3, Status = "ENTREGADO", Farmer = true, Buyer = true, Color = "#37bc61" },
                new OrderStatus { Id = 4, Status = "CANCELADO", Farmer = true, Buyer = true, Color = "#cd3700" },
                new OrderStatus { Id = 5, Status = "PRODUCTO DEFECTUOSO", Farmer = false, Buyer = true, Color = "#8b8682" }
            );

            var unit1 = new Unit { Id = 1, Code = "UND", Name = "Unidad" };
            var unit2 = new Unit { Id = 2, Code = "LIB", Name = "Libra" };
            var unit3 = new Unit { Id = 3, Code = "KLG", Name = "Kilogramo" };
            var unit4 = new Unit { Id = 4, Code = "BUL", Name = "Bulto" };
            var unit5 = new Unit { Id = 5, Code = "CAR", Name = "Carga" };
            var unit6 = new Unit { Id = 6, Code = "ARR", Name = "Arroba" };       
            context.Units.AddOrUpdate(
                u => u.Id,
                     unit1,
                     unit2,
                     unit3,
                     unit4,
                     unit5,
                     unit6
            );

            var product1 = new Product { Id = 1, Code = "1", Name = "Acelga" };
            var product2 = new Product { Id = 2, Code = "2", Name = "Apio" };
            var product3 = new Product { Id = 3, Code = "3", Name = "Brócoli" };
            var product4 = new Product { Id = 4, Code = "4", Name = "Cilantro" };
            var product5 = new Product { Id = 5, Code = "5", Name = "Coles" };
            var product6 = new Product { Id = 6, Code = "6", Name = "Coliflor" };
            var product7 = new Product { Id = 7, Code = "7", Name = "Espinaca" };
            var product8 = new Product { Id = 8, Code = "8", Name = "Lechuga batavia" };
            var product9 = new Product { Id = 9, Code = "9", Name = "Lechuga crespa morada" };
            var product10 = new Product { Id = 10, Code = "10", Name = "Lechuga crespa verde" };
            var product11 = new Product { Id = 11, Code = "11", Name = "Perejil" };
            var product12 = new Product { Id = 12, Code = "12", Name = "Repollo blanco" };
            var product13 = new Product { Id = 13, Code = "13", Name = "Repollo blanco bogotano" };
            var product14 = new Product { Id = 14, Code = "14", Name = "Repollo blanco valluno" };
            var product15 = new Product { Id = 15, Code = "15", Name = "Repollo morado" };
            var product16 = new Product { Id = 16, Code = "16", Name = "Repollo morado antioqueño" };
            var product17 = new Product { Id = 17, Code = "17", Name = "Repollo verde regional" };
            var product18 = new Product { Id = 18, Code = "18", Name = "Cebolla cabezona blanca" };
            var product19 = new Product { Id = 19, Code = "19", Name = "Cebolla cabezona blanca bogotana" };
            var product20 = new Product { Id = 20, Code = "20", Name = "Cebolla cabezona blanca ecuatoriana" };
            var product21 = new Product { Id = 21, Code = "21", Name = "Cebolla cabezona blanca importada" };
            var product22 = new Product { Id = 22, Code = "22", Name = "Cebolla cabezona blanca pastusa" };
            var product23 = new Product { Id = 23, Code = "23", Name = "Cebolla cabezona blanca peruana" };
            var product24 = new Product { Id = 24, Code = "24", Name = "Cebolla cabezona roja" };
            var product25 = new Product { Id = 25, Code = "25", Name = "Cebolla cabezona roja ecuatoriana" };
            var product26 = new Product { Id = 26, Code = "26", Name = "Cebolla cabezona roja ocañera" };
            var product27 = new Product { Id = 27, Code = "27", Name = "Cebolla cabezona roja peruana" };
            var product28 = new Product { Id = 28, Code = "28", Name = "Cebolla cabezona roja importada" };
            var product29 = new Product { Id = 29, Code = "29", Name = "Cebolla junca" };
            var product30 = new Product { Id = 30, Code = "30", Name = "Cebolla junca Aquitania" };
            var product31 = new Product { Id = 31, Code = "31", Name = "Cebolla junca Berlín" };
            var product32 = new Product { Id = 32, Code = "32", Name = "Cebolla junca pastusa" };
            var product33 = new Product { Id = 33, Code = "33", Name = "Cebolla junca Tenerife" };
            var product34 = new Product { Id = 34, Code = "34", Name = "Cebolla puerro" };
            var product35 = new Product { Id = 35, Code = "35", Name = "Cebollín chino" };
            var product36 = new Product { Id = 36, Code = "36", Name = "Arveja verde en vaina" };
            var product37 = new Product { Id = 37, Code = "37", Name = "Arveja verde en vaina antioqueña" };
            var product38 = new Product { Id = 38, Code = "38", Name = "Arveja verde en vaina pastusa" };
            var product39 = new Product { Id = 39, Code = "39", Name = "Fríjol verde bolo" };
            var product40 = new Product { Id = 40, Code = "40", Name = "Fríjol verde cargamanto" };
            var product41 = new Product { Id = 41, Code = "41", Name = "Fríjol verde en vaina" };
            var product42 = new Product { Id = 42, Code = "42", Name = "Haba verde" };
            var product43 = new Product { Id = 43, Code = "43", Name = "Habichuela" };
            var product44 = new Product { Id = 44, Code = "44", Name = "Habichuela larga" };
            var product45 = new Product { Id = 45, Code = "45", Name = "Tomate chonto" };
            var product46 = new Product { Id = 46, Code = "46", Name = "Tomate chonto antioqueño" };
            var product47 = new Product { Id = 47, Code = "47", Name = "Tomate chonto valluno" };
            var product48 = new Product { Id = 48, Code = "48", Name = "Tomate larga vida" };
            var product49 = new Product { Id = 49, Code = "49", Name = "Tomate riñón" };
            var product50 = new Product { Id = 50, Code = "50", Name = "Tomate riñón valluno" };
            var product51 = new Product { Id = 51, Code = "51", Name = "Tomate Riogrande" };
            var product52 = new Product { Id = 52, Code = "52", Name = "Tomate riogrande bumangués" };
            var product53 = new Product { Id = 53, Code = "53", Name = "Tomate riogrande ocañero" };
            var product54 = new Product { Id = 54, Code = "54", Name = "Zanahoria" };
            var product55 = new Product { Id = 55, Code = "55", Name = "Zanahoria bogotana" };
            var product56 = new Product { Id = 56, Code = "56", Name = "Zanahoria larga vida" };
            var product57 = new Product { Id = 57, Code = "57", Name = "Ahuyama" };
            var product58 = new Product { Id = 58, Code = "58", Name = "Ají dulce" };
            var product59 = new Product { Id = 59, Code = "59", Name = "Ají topito dulce" };
            var product60 = new Product { Id = 60, Code = "60", Name = "Ajo" };
            var product61 = new Product { Id = 61, Code = "61", Name = "Ajo importado" };
            var product62 = new Product { Id = 62, Code = "62", Name = "Berenjena" };
            var product63 = new Product { Id = 63, Code = "63", Name = "Calabacín" };
            var product64 = new Product { Id = 64, Code = "64", Name = "Calabaza" };
            var product65 = new Product { Id = 65, Code = "65", Name = "Chócolo mazorca" };
            var product66 = new Product { Id = 66, Code = "66", Name = "Cidra" };
            var product67 = new Product { Id = 67, Code = "67", Name = "Pepino cohombro" };
            var product68 = new Product { Id = 68, Code = "68", Name = "Pepino de rellenar" };
            var product69 = new Product { Id = 69, Code = "69", Name = "Pimentón" };
            var product70 = new Product { Id = 70, Code = "70", Name = "Rábano rojo" };
            var product71 = new Product { Id = 71, Code = "71", Name = "Remolacha" };
            var product72 = new Product { Id = 72, Code = "72", Name = "Remolacha antioqueña" };
            var product73 = new Product { Id = 73, Code = "73", Name = "Remolacha bogotana" };
            var product74 = new Product { Id = 74, Code = "74", Name = "Remolacha pastusa" };
            var product75 = new Product { Id = 75, Code = "75", Name = "Remolacha regional" };
            var product76 = new Product { Id = 76, Code = "76", Name = "Limón común" };
            var product77 = new Product { Id = 77, Code = "77", Name = "Limón común Ciénaga" };
            var product78 = new Product { Id = 78, Code = "78", Name = "Limón común ecuatoriano" };
            var product79 = new Product { Id = 79, Code = "79", Name = "Limón común valluno" };
            var product80 = new Product { Id = 80, Code = "80", Name = "Limón mandarino" };
            var product81 = new Product { Id = 81, Code = "81", Name = "Limón tahití" };
            var product82 = new Product { Id = 82, Code = "82", Name = "Mandarina arrayana" };
            var product83 = new Product { Id = 83, Code = "83", Name = "Mandarina común" };
            var product84 = new Product { Id = 84, Code = "84", Name = "Mandarina Oneco" };
            var product85 = new Product { Id = 85, Code = "85", Name = "Naranja común" };
            var product86 = new Product { Id = 86, Code = "86", Name = "Naranja valencia" };
            var product87 = new Product { Id = 87, Code = "87", Name = "Tangelo" };
            var product88 = new Product { Id = 88, Code = "88", Name = "Aguacate común" };
            var product89 = new Product { Id = 89, Code = "89", Name = "Aguacate hass" };
            var product90 = new Product { Id = 90, Code = "90", Name = "Aguacate papelillo" };
            var product91 = new Product { Id = 91, Code = "91", Name = "Badea" };
            var product92 = new Product { Id = 92, Code = "92", Name = "Banano bocadillo" };
            var product93 = new Product { Id = 93, Code = "93", Name = "Banano criollo" };
            var product94 = new Product { Id = 94, Code = "94", Name = "Banano Urabá" };
            var product95 = new Product { Id = 95, Code = "95", Name = "Borojó" };
            var product96 = new Product { Id = 96, Code = "96", Name = "Breva" };
            var product97 = new Product { Id = 97, Code = "97", Name = "Ciruela negra chilena" };
            var product98 = new Product { Id = 98, Code = "98", Name = "Ciruela roja" };
            var product99 = new Product { Id = 99, Code = "99", Name = "Coco" };
            var product100 = new Product { Id = 100, Code = "100", Name = "Curuba larga" };
            var product101 = new Product { Id = 101, Code = "101", Name = "Curuba redonda" };
            var product102 = new Product { Id = 102, Code = "102", Name = "Durazno importado" };
            var product103 = new Product { Id = 103, Code = "103", Name = "Durazno nacional" };
            var product104 = new Product { Id = 104, Code = "104", Name = "Feijoa" };
            var product105 = new Product { Id = 105, Code = "105", Name = "Fresa" };
            var product106 = new Product { Id = 106, Code = "106", Name = "Granadilla" };
            var product107 = new Product { Id = 107, Code = "107", Name = "Guanábana" };
            var product108 = new Product { Id = 108, Code = "108", Name = "Guayaba agria" };
            var product109 = new Product { Id = 109, Code = "109", Name = "Guayaba atlántico" };
            var product110 = new Product { Id = 110, Code = "110", Name = "Guayaba común" };
            var product111 = new Product { Id = 111, Code = "111", Name = "Guayaba manzana" };
            var product112 = new Product { Id = 112, Code = "112", Name = "Guayaba pera" };
            var product113 = new Product { Id = 113, Code = "113", Name = "Gulupa" };
            var product114 = new Product { Id = 114, Code = "114", Name = "Higo" };
            var product115 = new Product { Id = 115, Code = "115", Name = "Kiwi" };
            var product116 = new Product { Id = 116, Code = "116", Name = "Lulo" };
            var product117 = new Product { Id = 117, Code = "117", Name = "Mango común" };
            var product118 = new Product { Id = 118, Code = "118", Name = "Mango costeño" };
            var product119 = new Product { Id = 119, Code = "119", Name = "Mango de azúcar" };
            var product120 = new Product { Id = 120, Code = "120", Name = "Mango kent" };
            var product121 = new Product { Id = 121, Code = "121", Name = "Mango manzano" };
            var product122 = new Product { Id = 122, Code = "122", Name = "Mango mariquiteño" };
            var product123 = new Product { Id = 123, Code = "123", Name = "Mango reina" };
            var product124 = new Product { Id = 124, Code = "124", Name = "Mango tommy" };
            var product125 = new Product { Id = 125, Code = "125", Name = "Manzana nacional" };
            var product126 = new Product { Id = 126, Code = "126", Name = "Manzana roja importada" };
            var product127 = new Product { Id = 127, Code = "127", Name = "Manzana royal gala importada" };
            var product128 = new Product { Id = 128, Code = "128", Name = "Manzana verde importada" };
            var product129 = new Product { Id = 129, Code = "129", Name = "Maracuyá antioqueño" };
            var product130 = new Product { Id = 130, Code = "130", Name = "Maracuyá huilense" };
            var product131 = new Product { Id = 131, Code = "131", Name = "Maracuyá santandereano" };
            var product132 = new Product { Id = 132, Code = "132", Name = "Maracuyá valluno" };
            var product133 = new Product { Id = 133, Code = "133", Name = "Maracuyá " };
            var product134 = new Product { Id = 134, Code = "134", Name = "Melón cantalup" };
            var product135 = new Product { Id = 135, Code = "135", Name = "Mora de castilla" };
            var product136 = new Product { Id = 136, Code = "136", Name = "Papaya hawaiana" };
            var product137 = new Product { Id = 137, Code = "137", Name = "Papaya maradol" };
            var product138 = new Product { Id = 138, Code = "138", Name = "Papaya melona" };
            var product139 = new Product { Id = 139, Code = "139", Name = "Papaya redonda" };
            var product140 = new Product { Id = 140, Code = "140", Name = "Patilla" };
            var product141 = new Product { Id = 141, Code = "141", Name = "Pera importada" };
            var product142 = new Product { Id = 142, Code = "142", Name = "Pera nacional" };
            var product143 = new Product { Id = 143, Code = "143", Name = "Piña cayena" };
            var product144 = new Product { Id = 144, Code = "144", Name = "Piña gold" };
            var product145 = new Product { Id = 145, Code = "145", Name = "Piña manzana" };
            var product146 = new Product { Id = 146, Code = "146", Name = "Piña perolera" };
            var product147 = new Product { Id = 147, Code = "147", Name = "Pitahaya" };
            var product148 = new Product { Id = 148, Code = "148", Name = "Tomate de árbol" };
            var product149 = new Product { Id = 149, Code = "149", Name = "Uchuva con cáscara" };
            var product150 = new Product { Id = 150, Code = "150", Name = "Uva importada" };
            var product151 = new Product { Id = 151, Code = "151", Name = "Uva isabela" };
            var product152 = new Product { Id = 152, Code = "152", Name = "Uva negra" };
            var product153 = new Product { Id = 153, Code = "153", Name = "Uva red globe nacional" };
            var product154 = new Product { Id = 154, Code = "154", Name = "Uva roja" };
            var product155 = new Product { Id = 155, Code = "155", Name = "Uva verde" };
            var product156 = new Product { Id = 156, Code = "156", Name = "Zapote" };
            var product157 = new Product { Id = 157, Code = "157", Name = "Papa capira" };
            var product158 = new Product { Id = 158, Code = "158", Name = "Papa capira carmenia" };
            var product159 = new Product { Id = 159, Code = "159", Name = "Papa criolla limpia" };
            var product160 = new Product { Id = 160, Code = "160", Name = "Papa Criolla para lavar" };
            var product161 = new Product { Id = 161, Code = "161", Name = "Papa criolla sucia" };
            var product162 = new Product { Id = 162, Code = "162", Name = "Papa cumanday" };
            var product163 = new Product { Id = 163, Code = "163", Name = "Papa ICA-Huila" };
            var product164 = new Product { Id = 164, Code = "164", Name = "Papa morasurco" };
            var product165 = new Product { Id = 165, Code = "165", Name = "Papa nevada" };
            var product166 = new Product { Id = 166, Code = "166", Name = "Papa parda para lavar" };
            var product167 = new Product { Id = 167, Code = "167", Name = "Papa parda pastusa" };
            var product168 = new Product { Id = 168, Code = "168", Name = "Papa puracé" };
            var product169 = new Product { Id = 169, Code = "169", Name = "Papa R-12 negra" };
            var product170 = new Product { Id = 170, Code = "170", Name = "Papa R-12 roja" };
            var product171 = new Product { Id = 171, Code = "171", Name = "Papa roja peruana" };
            var product172 = new Product { Id = 172, Code = "172", Name = "Papa ruby" };
            var product173 = new Product { Id = 173, Code = "173", Name = "Papa sabanera" };
            var product174 = new Product { Id = 174, Code = "174", Name = "Papa San Félix" };
            var product175 = new Product { Id = 175, Code = "175", Name = "Papa suprema" };
            var product176 = new Product { Id = 176, Code = "176", Name = "Papa tequendama" };
            var product177 = new Product { Id = 177, Code = "177", Name = "Papa tocana" };
            var product178 = new Product { Id = 178, Code = "178", Name = "Papa tocarreña" };
            var product179 = new Product { Id = 179, Code = "179", Name = "Papa única" };
            var product180 = new Product { Id = 180, Code = "180", Name = "Plátano comino" };
            var product181 = new Product { Id = 181, Code = "181", Name = "Plátano dominico hartón maduro" };
            var product182 = new Product { Id = 182, Code = "182", Name = "Plátano dominico hartón verde" };
            var product183 = new Product { Id = 183, Code = "183", Name = "Plátano dominico maduro" };
            var product184 = new Product { Id = 184, Code = "184", Name = "Plátano dominico verde" };
            var product185 = new Product { Id = 185, Code = "185", Name = "Plátano guineo" };
            var product186 = new Product { Id = 186, Code = "186", Name = "Plátano hartón maduro" };
            var product187 = new Product { Id = 187, Code = "187", Name = "Plátano hartón verde" };
            var product188 = new Product { Id = 188, Code = "188", Name = "Plátano hartón verde ecuatoriano" };
            var product189 = new Product { Id = 189, Code = "189", Name = "Plátano hartón verde llanero" };
            var product190 = new Product { Id = 190, Code = "190", Name = "Plátano hartón verde venezolano" };
            var product191 = new Product { Id = 191, Code = "191", Name = "Yuca chirosa" };
            var product192 = new Product { Id = 192, Code = "192", Name = "Yuca criolla" };
            var product193 = new Product { Id = 193, Code = "193", Name = "Yuca ICA" };
            var product194 = new Product { Id = 194, Code = "194", Name = "Yuca llanera" };
            var product195 = new Product { Id = 195, Code = "195", Name = "Arracacha amarilla" };
            var product196 = new Product { Id = 196, Code = "196", Name = "Arracacha blanca" };
            var product197 = new Product { Id = 197, Code = "197", Name = "Ñame criollo" };
            var product198 = new Product { Id = 198, Code = "198", Name = "Ñame diamante" };
            var product199 = new Product { Id = 199, Code = "199", Name = "Ñame espino" };
            var product200 = new Product { Id = 200, Code = "200", Name = "Ulluco" };
            var product201 = new Product { Id = 201, Code = "201", Name = "Arroz de primera" };
            var product202 = new Product { Id = 202, Code = "202", Name = "Arroz de segunda" };
            var product203 = new Product { Id = 203, Code = "203", Name = "Arroz excelso" };
            var product204 = new Product { Id = 204, Code = "204", Name = "Arroz sopa cristal" };
            var product205 = new Product { Id = 205, Code = "205", Name = "Arveja amarilla seca importada" };
            var product206 = new Product { Id = 206, Code = "206", Name = "Arveja enlatada" };
            var product207 = new Product { Id = 207, Code = "207", Name = "Arveja verde seca importada" };
            var product208 = new Product { Id = 208, Code = "208", Name = "Cuchuco de cebada" };
            var product209 = new Product { Id = 209, Code = "209", Name = "Cuchuco de maíz" };
            var product210 = new Product { Id = 210, Code = "210", Name = "Fríjol bolón" };
            var product211 = new Product { Id = 211, Code = "211", Name = "Fríjol cabeza negra importado" };
            var product212 = new Product { Id = 212, Code = "212", Name = "Fríjol cabeza negra nacional" };
            var product213 = new Product { Id = 213, Code = "213", Name = "Fríjol calima" };
            var product214 = new Product { Id = 214, Code = "214", Name = "Fríjol cargamanto blanco" };
            var product215 = new Product { Id = 215, Code = "215", Name = "Fríjol cargamanto rojo" };
            var product216 = new Product { Id = 216, Code = "216", Name = "Fríjol enlatado" };
            var product217 = new Product { Id = 217, Code = "217", Name = "Fríjol nima calima" };
            var product218 = new Product { Id = 218, Code = "218", Name = "Fríjol palomito importado" };
            var product219 = new Product { Id = 219, Code = "219", Name = "Fríjol radical" };
            var product220 = new Product { Id = 220, Code = "220", Name = "Fríjol uribe rosado" };
            var product221 = new Product { Id = 221, Code = "221", Name = "Fríjol zaragoza" };
            var product222 = new Product { Id = 222, Code = "222", Name = "Garbanzo importado" };
            var product223 = new Product { Id = 223, Code = "223", Name = "Garbanzo nacional" };
            var product224 = new Product { Id = 224, Code = "224", Name = "Lenteja importada" };
            var product225 = new Product { Id = 225, Code = "225", Name = "Lenteja nacional" };
            var product226 = new Product { Id = 226, Code = "226", Name = "Maíz amarillo cáscara" };
            var product227 = new Product { Id = 227, Code = "227", Name = "Maíz amarillo retrillado" };
            var product228 = new Product { Id = 228, Code = "228", Name = "Maíz amarillo trillado" };
            var product229 = new Product { Id = 229, Code = "229", Name = "Maíz blanco cáscara" };
            var product230 = new Product { Id = 230, Code = "230", Name = "Maíz blanco retrillado" };
            var product231 = new Product { Id = 231, Code = "231", Name = "Maíz blanco trillado" };
            var product232 = new Product { Id = 232, Code = "232", Name = "Maíz enlatado" };
            var product233 = new Product { Id = 233, Code = "233", Name = "Maíz pira" };
            var product234 = new Product { Id = 234, Code = "234", Name = "Maíz porva" };
            var product235 = new Product { Id = 235, Code = "235", Name = "Leche pasteurizada UHT" };
            var product236 = new Product { Id = 236, Code = "236", Name = "Leche en polvo" };
            var product237 = new Product { Id = 237, Code = "237", Name = "Queso campesino" };
            var product238 = new Product { Id = 238, Code = "238", Name = "Queso costeño" };
            var product239 = new Product { Id = 239, Code = "239", Name = "Queso cuajada" };
            var product240 = new Product { Id = 240, Code = "240", Name = "Queso doble crema" };
            var product241 = new Product { Id = 241, Code = "241", Name = "Huevo blanco B" };
            var product242 = new Product { Id = 242, Code = "242", Name = "Huevo blanco A" };
            var product243 = new Product { Id = 243, Code = "243", Name = "Huevo blanco AA" };
            var product244 = new Product { Id = 244, Code = "244", Name = "Huevo blanco extra" };
            var product245 = new Product { Id = 245, Code = "245", Name = "Huevo rojo B" };
            var product246 = new Product { Id = 246, Code = "246", Name = "Huevo rojo A" };
            var product247 = new Product { Id = 247, Code = "247", Name = "Huevo rojo AA" };
            var product248 = new Product { Id = 248, Code = "248", Name = "Huevo rojo extra" };
            var product249 = new Product { Id = 249, Code = "249", Name = "Carne de res, cadera" };
            var product250 = new Product { Id = 250, Code = "250", Name = "Carne de res, chatas" };
            var product251 = new Product { Id = 251, Code = "251", Name = "Carne de res, costilla" };
            var product252 = new Product { Id = 252, Code = "252", Name = "Carne de res, bola de brazo" };
            var product253 = new Product { Id = 253, Code = "253", Name = "Carne de res, bola de pierna" };
            var product254 = new Product { Id = 254, Code = "254", Name = "Carne de res, bota" };
            var product255 = new Product { Id = 255, Code = "255", Name = "Carne de res, centro de pierna" };
            var product256 = new Product { Id = 256, Code = "256", Name = "Carne de res, cogote" };
            var product257 = new Product { Id = 257, Code = "257", Name = "Carne de res en canal" };
            var product258 = new Product { Id = 258, Code = "258", Name = "Carne de res, falda" };
            var product259 = new Product { Id = 259, Code = "259", Name = "Carne de res, lomo de brazo" };
            var product260 = new Product { Id = 260, Code = "260", Name = "Carne de res, lomo fino" };
            var product261 = new Product { Id = 261, Code = "261", Name = "Carne de res molida, murillo" };
            var product262 = new Product { Id = 262, Code = "262", Name = "Carne de res, morrillo" };
            var product263 = new Product { Id = 263, Code = "263", Name = "Carne de res, muchacho" };
            var product264 = new Product { Id = 264, Code = "264", Name = "Carne de res, murillo" };
            var product265 = new Product { Id = 265, Code = "265", Name = "Carne de res, paletero" };
            var product266 = new Product { Id = 266, Code = "266", Name = "Carne de res, pecho" };
            var product267 = new Product { Id = 267, Code = "267", Name = "Carne de res, punta de anca" };
            var product268 = new Product { Id = 268, Code = "268", Name = "Carne de res, sobrebarriga" };
            var product269 = new Product { Id = 269, Code = "269", Name = "Carne de cerdo en canal" };
            var product270 = new Product { Id = 270, Code = "270", Name = "Carne de cerdo, brazo con hueso" };
            var product271 = new Product { Id = 271, Code = "271", Name = "Carne de cerdo, brazo sin hueso" };
            var product272 = new Product { Id = 272, Code = "272", Name = "Carne de cerdo, cabeza de lomo" };
            var product273 = new Product { Id = 273, Code = "273", Name = "Carne de cerdo, chuleta de lomo" };
            var product274 = new Product { Id = 274, Code = "274", Name = "Carne de cerdo, costilla" };
            var product275 = new Product { Id = 275, Code = "275", Name = "Carne de cerdo, espinazo" };
            var product276 = new Product { Id = 276, Code = "276", Name = "Carne de cerdo, lomo con hueso" };
            var product277 = new Product { Id = 277, Code = "277", Name = "Carne de cerdo, lomo sin hueso" };
            var product278 = new Product { Id = 278, Code = "278", Name = "Carne de cerdo, pernil con hueso" };
            var product279 = new Product { Id = 279, Code = "279", Name = "Carne de cerdo, pernil sin hueso" };
            var product280 = new Product { Id = 280, Code = "280", Name = "Carne de cerdo, tocineta plancha" };
            var product281 = new Product { Id = 281, Code = "281", Name = "Carne de cerdo, tocino barriga" };
            var product282 = new Product { Id = 282, Code = "282", Name = "Carne de cerdo, tocino papada" };
            var product283 = new Product { Id = 283, Code = "283", Name = "Alas de pollo con costillar" };
            var product284 = new Product { Id = 284, Code = "284", Name = "Alas de pollo sin costillar" };
            var product285 = new Product { Id = 285, Code = "285", Name = "Menudencias de pollo" };
            var product286 = new Product { Id = 286, Code = "286", Name = "Muslos de pollo con rabadilla" };
            var product287 = new Product { Id = 287, Code = "287", Name = "Muslos de pollo sin rabadilla" };
            var product288 = new Product { Id = 288, Code = "288", Name = "Pechuga de pollo" };
            var product289 = new Product { Id = 289, Code = "289", Name = "Pierna pernil con rabadilla" };
            var product290 = new Product { Id = 290, Code = "290", Name = "Pierna pernil sin rabadilla" };
            var product291 = new Product { Id = 291, Code = "291", Name = "Piernas de pollo" };
            var product292 = new Product { Id = 292, Code = "292", Name = "Pollo entero congelado con vísceras" };
            var product293 = new Product { Id = 293, Code = "293", Name = "Pollo entero congelado sin vísceras" };
            var product294 = new Product { Id = 294, Code = "294", Name = "Pollo entero fresco con vísceras" };
            var product295 = new Product { Id = 295, Code = "295", Name = "Pollo entero fresco sin vísceras" };
            var product296 = new Product { Id = 296, Code = "296", Name = "Rabadillas de pollo" };
            var product297 = new Product { Id = 297, Code = "297", Name = "Tilapia, filete congelado" };
            var product298 = new Product { Id = 298, Code = "298", Name = "Almejas con concha" };
            var product299 = new Product { Id = 299, Code = "299", Name = "Almejas sin concha" };
            var product300 = new Product { Id = 300, Code = "300", Name = "Bagre rayado entero congelado" };
            var product301 = new Product { Id = 301, Code = "301", Name = "Bagre rayado entero fresco" };
            var product302 = new Product { Id = 302, Code = "302", Name = "Bagre rayado en postas congelado" };
            var product303 = new Product { Id = 303, Code = "303", Name = "Bagre rayado en postas fresco" };
            var product304 = new Product { Id = 304, Code = "304", Name = "Blanquillo entero fresco" };
            var product305 = new Product { Id = 305, Code = "305", Name = "Bocachico criollo fresco" };
            var product306 = new Product { Id = 306, Code = "306", Name = "Bocachico importado congelado" };
            var product307 = new Product { Id = 307, Code = "307", Name = "Cachama de cultivo fresca" };
            var product308 = new Product { Id = 308, Code = "308", Name = "Calamar anillos" };
            var product309 = new Product { Id = 309, Code = "309", Name = "Calamar blanco entero" };
            var product310 = new Product { Id = 310, Code = "310", Name = "Calamar morado entero" };
            var product311 = new Product { Id = 311, Code = "311", Name = "Camarón tigre precocido seco" };
            var product312 = new Product { Id = 312, Code = "312", Name = "Camarón tití precocido seco" };
            var product313 = new Product { Id = 313, Code = "313", Name = "Capaz Magdalena fresco" };
            var product314 = new Product { Id = 314, Code = "314", Name = "Cazuela de mariscos" };
            var product315 = new Product { Id = 315, Code = "315", Name = "Corvina, filete congelado nacional" };
            var product316 = new Product { Id = 316, Code = "316", Name = "Langostino 16-20" };
            var product317 = new Product { Id = 317, Code = "317", Name = "Langostino U12" };
            var product318 = new Product { Id = 318, Code = "318", Name = "Merluza, filete importado" };
            var product319 = new Product { Id = 319, Code = "319", Name = "Merluza, filete nacional" };
            var product320 = new Product { Id = 320, Code = "320", Name = "Mojarra lora entera fresca" };
            var product321 = new Product { Id = 321, Code = "321", Name = "Mojarra lora entera congelada" };
            var product322 = new Product { Id = 322, Code = "322", Name = "Nicuro fresco" };
            var product323 = new Product { Id = 323, Code = "323", Name = "Palmitos de mar" };
            var product324 = new Product { Id = 324, Code = "324", Name = "Pargo rojo entero fresco" };
            var product325 = new Product { Id = 325, Code = "325", Name = "Pargo rojo platero" };
            var product326 = new Product { Id = 326, Code = "326", Name = "Pescado cabezas" };
            var product327 = new Product { Id = 327, Code = "327", Name = "Róbalo, filete congelado" };
            var product328 = new Product { Id = 328, Code = "328", Name = "Salmón, filete congelado" };
            var product329 = new Product { Id = 329, Code = "329", Name = "Sierra entera congelada" };
            var product330 = new Product { Id = 330, Code = "330", Name = "Tilapia, lomitos" };
            var product331 = new Product { Id = 331, Code = "331", Name = "Tilapia roja entera congelada" };
            var product332 = new Product { Id = 332, Code = "332", Name = "Tilapia roja entera fresca" };
            var product333 = new Product { Id = 333, Code = "333", Name = "Toyo blanco, filete congelado" };
            var product334 = new Product { Id = 334, Code = "334", Name = "Trucha en corte mariposa" };
            var product335 = new Product { Id = 335, Code = "335", Name = "Trucha entera fresca" };
            var product336 = new Product { Id = 336, Code = "336", Name = "Atún en lata" };
            var product337 = new Product { Id = 337, Code = "337", Name = "Sardinas en lata" };
            var product338 = new Product { Id = 338, Code = "338", Name = "Aceite girasol" };
            var product339 = new Product { Id = 339, Code = "339", Name = "Aceite soya" };
            var product340 = new Product { Id = 340, Code = "340", Name = "Aceite vegetal mezcla" };
            var product341 = new Product { Id = 341, Code = "341", Name = "Manteca" };
            var product342 = new Product { Id = 342, Code = "342", Name = "Margarina" };
            var product343 = new Product { Id = 343, Code = "343", Name = "Panela cuadrada blanca" };
            var product344 = new Product { Id = 344, Code = "344", Name = "Panela cuadrada morena" };
            var product345 = new Product { Id = 345, Code = "345", Name = "Panela redonda morena" };
            var product346 = new Product { Id = 346, Code = "346", Name = "Azúcar morena" };
            var product347 = new Product { Id = 347, Code = "347", Name = "Azúcar refinada" };
            var product348 = new Product { Id = 348, Code = "348", Name = "Azúcar sulfitada" };
            var product349 = new Product { Id = 349, Code = "349", Name = "Avena en hojuelas" };
            var product350 = new Product { Id = 350, Code = "350", Name = "Avena molida" };
            var product351 = new Product { Id = 351, Code = "351", Name = "Bocadillo veleño" };
            var product352 = new Product { Id = 352, Code = "352", Name = "Café instantáneo" };
            var product353 = new Product { Id = 353, Code = "353", Name = "Café molido" };
            var product354 = new Product { Id = 354, Code = "354", Name = "Chocolate amargo" };
            var product355 = new Product { Id = 355, Code = "355", Name = "Chocolate dulce" };
            var product356 = new Product { Id = 356, Code = "356", Name = "Chocolate instantáneo" };
            var product357 = new Product { Id = 357, Code = "357", Name = "Color" };
            var product358 = new Product { Id = 358, Code = "358", Name = "Fécula de maíz" };
            var product359 = new Product { Id = 359, Code = "359", Name = "Galletas dulces redondas con crema" };
            var product360 = new Product { Id = 360, Code = "360", Name = "Galletas saladas 3 tacos" };
            var product361 = new Product { Id = 361, Code = "361", Name = "Gelatina" };
            var product362 = new Product { Id = 362, Code = "362", Name = "Harina de trigo" };
            var product363 = new Product { Id = 363, Code = "363", Name = "Harina precocida de maíz" };
            var product364 = new Product { Id = 364, Code = "364", Name = "Jugo de frutas" };
            var product365 = new Product { Id = 365, Code = "365", Name = "Jugo instantáneo" };
            var product366 = new Product { Id = 366, Code = "366", Name = "Mayonesa doy pack" };
            var product367 = new Product { Id = 367, Code = "367", Name = "Mostaza doy pack" };
            var product368 = new Product { Id = 368, Code = "368", Name = "Papa frita" };
            var product369 = new Product { Id = 369, Code = "369", Name = "Pastas alimenticias" };
            var product370 = new Product { Id = 370, Code = "370", Name = "Sal yodada" };
            var product371 = new Product { Id = 371, Code = "371", Name = "Salsa de tomate doy pack" };
            var product372 = new Product { Id = 372, Code = "372", Name = "Sopa de pollo" };
            var product373 = new Product { Id = 373, Code = "373", Name = "Vinagre" };
            var product374 = new Product { Id = 374, Code = "374", Name = "Aguas y tés" };
            var product375 = new Product { Id = 375, Code = "375", Name = "Bebidas hidratantes" };
            var product376 = new Product { Id = 376, Code = "376", Name = "Gaseosas y maltas" };
            var product377 = new Product { Id = 377, Code = "377", Name = "Jugos y refrescos" };
            var product378 = new Product { Id = 378, Code = "378", Name = "Avenas líquidas" };
            var product379 = new Product { Id = 379, Code = "379", Name = "Leche de soya" };
            var product380 = new Product { Id = 380, Code = "380", Name = "Arepas y tortillas" };
            var product381 = new Product { Id = 381, Code = "381", Name = "Conservas y enlatados" };
            var product382 = new Product { Id = 382, Code = "382", Name = "Sopas" };
            var product383 = new Product { Id = 383, Code = "383", Name = "Cremas" };
            var product384 = new Product { Id = 384, Code = "384", Name = "Harinas y mezclas" };
            var product385 = new Product { Id = 385, Code = "385", Name = "Miel" };
            var product386 = new Product { Id = 386, Code = "386", Name = "Edulcolorantes" };
            var product387 = new Product { Id = 387, Code = "387", Name = "Salsas y bases" };
            var product388 = new Product { Id = 388, Code = "388", Name = "Ajís" };
            var product389 = new Product { Id = 389, Code = "389", Name = "Condimentos" };
            var product390 = new Product { Id = 390, Code = "390", Name = "Caldos" };
            var product391 = new Product { Id = 391, Code = "391", Name = "Salsas de tomate" };
            var product392 = new Product { Id = 392, Code = "392", Name = "Mayonesas" };
            var product393 = new Product { Id = 393, Code = "393", Name = "Mostazas" };
            var product394 = new Product { Id = 394, Code = "394", Name = "Bebidas aromáticas y tés" };
            var product395 = new Product { Id = 395, Code = "395", Name = "Chocolate de mesa" };
            var product396 = new Product { Id = 396, Code = "396", Name = "Modificadores de leche" };
            var product397 = new Product { Id = 397, Code = "397", Name = "Manís" };
            var product398 = new Product { Id = 398, Code = "398", Name = "Frutos deshidratados" };
            var product399 = new Product { Id = 399, Code = "399", Name = "Frutos secos" };
            var product400 = new Product { Id = 400, Code = "400", Name = "Papas fritas" };
            var product401 = new Product { Id = 401, Code = "401", Name = "Pasabocas surtidos" };
            var product402 = new Product { Id = 402, Code = "402", Name = "Gelatina dietética y sin sabor" };
            var product403 = new Product { Id = 403, Code = "403", Name = "Postres para preparar" };
            var product404 = new Product { Id = 404, Code = "404", Name = "Cereales" };
            var product405 = new Product { Id = 405, Code = "405", Name = "Granolas" };
            var product406 = new Product { Id = 406, Code = "406", Name = "Cereales en barra" };
            var product407 = new Product { Id = 407, Code = "407", Name = "Aceite de oliva" };
            var product408 = new Product { Id = 408, Code = "408", Name = "Vinos de cocina" };
            var product409 = new Product { Id = 409, Code = "409", Name = "Mermelada" };
            var product410 = new Product { Id = 410, Code = "410", Name = "Pan empacado" };
            var product411 = new Product { Id = 411, Code = "411", Name = "Pan fresco" };
            var product412 = new Product { Id = 412, Code = "412", Name = "Repostería" };
            var product413 = new Product { Id = 413, Code = "413", Name = "Pasteles y ponqués" };
            var product414 = new Product { Id = 414, Code = "414", Name = "Papillas y compotas" };
            var product415 = new Product { Id = 415, Code = "415", Name = "Comida congelada" };
            var product416 = new Product { Id = 416, Code = "416", Name = "Apanados" };
            var product417 = new Product { Id = 417, Code = "417", Name = "Hielo" };
            var product418 = new Product { Id = 418, Code = "418", Name = "Helados" };
            var product419 = new Product { Id = 419, Code = "419", Name = "Chocolates y estuches" };
            var product420 = new Product { Id = 420, Code = "420", Name = "Confitería" };
            var product421 = new Product { Id = 421, Code = "421", Name = "Galletas" };
            var product422 = new Product { Id = 422, Code = "422", Name = "Dulces típicos y bocadillos" };
            var product423 = new Product { Id = 423, Code = "423", Name = "Postres preparados" };
            var product424 = new Product { Id = 424, Code = "424", Name = "Vinos" };
            var product425 = new Product { Id = 425, Code = "425", Name = "Whiskys" };
            var product426 = new Product { Id = 426, Code = "426", Name = "Aguardientes" };
            var product427 = new Product { Id = 427, Code = "427", Name = "Rones" };
            var product428 = new Product { Id = 428, Code = "428", Name = "Vodkas" };
            var product429 = new Product { Id = 429, Code = "429", Name = "Tequilas" };
            var product430 = new Product { Id = 430, Code = "430", Name = "Aperitivos, cocteles y bases" };
            var product431 = new Product { Id = 431, Code = "431", Name = "Cervezas" };
            var product432 = new Product { Id = 432, Code = "432", Name = "Yuca" };
            var product433 = new Product { Id = 433, Code = "433", Name = "Arroz" };
            var product434 = new Product { Id = 434, Code = "434", Name = "Arveja" };
            var product435 = new Product { Id = 435, Code = "435", Name = "Fríjol" };
            var product436 = new Product { Id = 436, Code = "436", Name = "Garbanzo" };
            var product437 = new Product { Id = 437, Code = "437", Name = "Lenteja" };
            var product438 = new Product { Id = 438, Code = "438", Name = "Leche cruda" };
            var product439 = new Product { Id = 439, Code = "439", Name = "Huevo" };
            var product440 = new Product { Id = 440, Code = "440", Name = "Carne de res" };
            var product441 = new Product { Id = 441, Code = "441", Name = "Res en pie" };
            var product442 = new Product { Id = 442, Code = "442", Name = "Res de engorde" };
            var product443 = new Product { Id = 443, Code = "443", Name = "Carne de cerdo" };
            var product444 = new Product { Id = 444, Code = "444", Name = "Cerdo en pie" };
            var product445 = new Product { Id = 445, Code = "445", Name = "Carne de pollo" };
            var product446 = new Product { Id = 446, Code = "446", Name = "Pollo en pie" };
            var product447 = new Product { Id = 447, Code = "447", Name = "Gallina en pie" };
            var product448 = new Product { Id = 448, Code = "448", Name = "Tilapia" };
            var product449 = new Product { Id = 449, Code = "449", Name = "Almejas" };
            var product450 = new Product { Id = 450, Code = "450", Name = "Bagre" };
            var product451 = new Product { Id = 451, Code = "452", Name = "Bocachico" };
            var product452 = new Product { Id = 452, Code = "453", Name = "Cachama" };
            var product453 = new Product { Id = 453, Code = "454", Name = "Calamar" };
            var product454 = new Product { Id = 454, Code = "455", Name = "Camarón" };
            var product455 = new Product { Id = 455, Code = "456", Name = "Capaz" };
            var product456 = new Product { Id = 456, Code = "457", Name = "Corvina" };
            var product457 = new Product { Id = 457, Code = "458", Name = "Langostino" };
            var product458 = new Product { Id = 458, Code = "459", Name = "Merluza" };
            var product459 = new Product { Id = 459, Code = "460", Name = "Mojarra" };
            var product460 = new Product { Id = 460, Code = "461", Name = "Nicuro" };
            var product461 = new Product { Id = 461, Code = "462", Name = "Pargo rojo" };
            var product462 = new Product { Id = 462, Code = "463", Name = "Róbalo" };
            var product463 = new Product { Id = 463, Code = "464", Name = "Salmón" };
            var product464 = new Product { Id = 464, Code = "465", Name = "Sierra" };
            var product465 = new Product { Id = 465, Code = "466", Name = "Toyo blanco" };
            var product466 = new Product { Id = 466, Code = "467", Name = "Trucha" };
            var product467 = new Product { Id = 467, Code = "468", Name = "Panela(Sin Datos)" };
            var product468 = new Product { Id = 468, Code = "469", Name = "Azúcar" };
            var product469 = new Product { Id = 469, Code = "470", Name = "Café en grano" };
            var product470 = new Product { Id = 470, Code = "471", Name = "Pomelo" };
            var product471 = new Product { Id = 471, Code = "472", Name = "Níspero" };
            var product472 = new Product { Id = 472, Code = "474", Name = "Mangostino" };
            var product473 = new Product { Id = 473, Code = "475", Name = "Carambolo" };
            var product474 = new Product { Id = 474, Code = "476", Name = "Mamón" };
            var product475 = new Product { Id = 475, Code = "477", Name = "Corozo" };
            var product476 = new Product { Id = 476, Code = "478", Name = "Agraz" };
            var product477 = new Product { Id = 477, Code = "479", Name = "Caña de azúcar" };
            var product478 = new Product { Id = 478, Code = "480", Name = "Embutidos" };
            var product479 = new Product { Id = 479, Code = "481", Name = "Amasijos" };
            var product480 = new Product { Id = 480, Code = "520", Name = "Pargo rojo entero congelado" };
            var product481 = new Product { Id = 481, Code = "521", Name = "Pimentón verde" };
            var product482 = new Product { Id = 482, Code = "522", Name = "Queso Caquetá" };
            var product483 = new Product { Id = 483, Code = "553", Name = "Arroz paddy verde" };
            var product484 = new Product { Id = 484, Code = "554", Name = "Arroz paddy seco" };
            var product485 = new Product { Id = 485, Code = "555", Name = "Arroz cristal" };
            var product486 = new Product { Id = 486, Code = "556", Name = "Arroz granza" };
            var product487 = new Product { Id = 487, Code = "557", Name = "Harina de arroz" };
            var product488 = new Product { Id = 488, Code = "558", Name = "Arroz blanco empacado" };
            var product489 = new Product { Id = 489, Code = "559", Name = "Maíz amarillo cáscara importado" };
            var product490 = new Product { Id = 490, Code = "560", Name = "Arroz blanco importado" };
            var product491 = new Product { Id = 491, Code = "561", Name = "Arroz blanco en bulto" };
            var product492 = new Product { Id = 492, Code = "5200", Name = "Papa Betina" };
            var product493 = new Product { Id = 493, Code = "5893", Name = "Naranja Sweet" };
            var product494 = new Product { Id = 494, Code = "102020", Name = "Ahuyama peruana" };
            var product495 = new Product { Id = 495, Code = "102030", Name = "Ahuyama valluna" };
            var product496 = new Product { Id = 496, Code = "102040", Name = "Ahuyama unión" };
            var product497 = new Product { Id = 497, Code = "103020", Name = "Aji topito dulce" };
            var product498 = new Product { Id = 498, Code = "103030", Name = "Ají picante" };
            var product499 = new Product { Id = 499, Code = "104020", Name = "Ajo antioqueño" };
            var product500 = new Product { Id = 500, Code = "104030", Name = "Ajo blanco" };
            var product501 = new Product { Id = 501, Code = "104040", Name = "Ajo bogotanano" };
            var product502 = new Product { Id = 502, Code = "104060", Name = "Ajo regional" };
            var product503 = new Product { Id = 503, Code = "104070", Name = "Ajo rosado" };
            var product504 = new Product { Id = 504, Code = "104100", Name = "Ajo pastuso" };
            var product505 = new Product { Id = 505, Code = "105010", Name = "Alcachofa" };
            var product506 = new Product { Id = 506, Code = "106020", Name = "Apio bogotano" };
            var product507 = new Product { Id = 507, Code = "107030", Name = "Arveja verde en vaina Cajam" };
            var product508 = new Product { Id = 508, Code = "107060", Name = "Arveja verde en vaina Santa" };
            var product509 = new Product { Id = 509, Code = "107070", Name = "Arveja verde en vaina Sinda" };
            var product510 = new Product { Id = 510, Code = "109010", Name = "Brócoli" };
            var product511 = new Product { Id = 511, Code = "110020", Name = "Calabacín amarillo" };
            var product512 = new Product { Id = 512, Code = "110030", Name = "Calabacín verde" };
            var product513 = new Product { Id = 513, Code = "112030", Name = "Cebolla cabezona blanca bumangu" };
            var product514 = new Product { Id = 514, Code = "112040", Name = "Cebolla cabezona blanca regiona" };
            var product515 = new Product { Id = 515, Code = "112080", Name = "Cebolla cabezona morada" };
            var product516 = new Product { Id = 516, Code = "112100", Name = "Cebolla cabezona red creole" };
            var product517 = new Product { Id = 517, Code = "112120", Name = "Cebolla cabezona tambo" };
            var product518 = new Product { Id = 518, Code = "112160", Name = "Cebolla junca bumanguesa" };
            var product519 = new Product { Id = 519, Code = "112180", Name = "Cebolla junca palmireña" };
            var product520 = new Product { Id = 520, Code = "112190", Name = "Cebolla junca valluno" };
            var product521 = new Product { Id = 521, Code = "112195", Name = "Cebolla junca veleña" };
            var product522 = new Product { Id = 522, Code = "112260", Name = "Cebolla junca bogotana" };
            var product523 = new Product { Id = 523, Code = "118020", Name = "Fríjol verd. andino-agrario" };
            var product524 = new Product { Id = 524, Code = "118040", Name = "Fríjol verde calima" };
            var product525 = new Product { Id = 525, Code = "118060", Name = "Fríjol verde chocho rojo" };
            var product526 = new Product { Id = 526, Code = "118080", Name = "Frijol verde radical" };
            var product527 = new Product { Id = 527, Code = "120020", Name = "Habichuela regional" };
            var product528 = new Product { Id = 528, Code = "121020", Name = "Lechuga lisa" };
            var product529 = new Product { Id = 529, Code = "122010", Name = "Chocolo mazorca" };
            var product530 = new Product { Id = 530, Code = "122040", Name = "Chocolo desgranado" };
            var product531 = new Product { Id = 531, Code = "123030", Name = "Pepino común blanco" };
            var product532 = new Product { Id = 532, Code = "125012", Name = "Pimentón amarillo" };
            var product533 = new Product { Id = 533, Code = "125013", Name = "Pimentón rojo" };
            var product534 = new Product { Id = 534, Code = "125020", Name = "Pimentón chino" };
            var product535 = new Product { Id = 535, Code = "125030", Name = "Pimentón bumangués" };
            var product536 = new Product { Id = 536, Code = "128030", Name = "Repollo blanco bumangues" };
            var product537 = new Product { Id = 537, Code = "128040", Name = "Repollo blanco pastusa" };
            var product538 = new Product { Id = 538, Code = "128050", Name = "Repollo blanco pereirano" };
            var product539 = new Product { Id = 539, Code = "128090", Name = "Repollo morado bogotano" };
            var product540 = new Product { Id = 540, Code = "128095", Name = "Repollo verde bogotano" };
            var product541 = new Product { Id = 541, Code = "129050", Name = "Tomate Riogrande 1a" };
            var product542 = new Product { Id = 542, Code = "129060", Name = "Tomate Riogrande 2a" };
            var product543 = new Product { Id = 543, Code = "130010", Name = "Vitoria" };
            var product544 = new Product { Id = 544, Code = "131020", Name = "Zanahoria antioqueña" };
            var product545 = new Product { Id = 545, Code = "131040", Name = "Zanahoria bumanguesa" };
            var product546 = new Product { Id = 546, Code = "131050", Name = "Zanahoria Chitagá" };
            var product547 = new Product { Id = 547, Code = "131060", Name = "Zanahoria pastusa" };
            var product548 = new Product { Id = 548, Code = "131070", Name = "Zanahoria Ipialeña" };
            var product549 = new Product { Id = 549, Code = "131090", Name = "Zanahoria regional" };
            var product550 = new Product { Id = 550, Code = "131100", Name = "Zanahoria Duitama" };
            var product551 = new Product { Id = 551, Code = "131110", Name = "Zanahoria otra" };
            var product552 = new Product { Id = 552, Code = "132030", Name = "Col" };
            var product553 = new Product { Id = 553, Code = "132040", Name = "Col china" };
            var product554 = new Product { Id = 554, Code = "201020", Name = "Aguacate injerto" };
            var product555 = new Product { Id = 555, Code = "201040", Name = "Aguacate peruano" };
            var product556 = new Product { Id = 556, Code = "201051", Name = "Aguacate hass Tolima" };
            var product557 = new Product { Id = 557, Code = "201052", Name = "Aguacate hass Quindío" };
            var product558 = new Product { Id = 558, Code = "201053", Name = "Aguacate hass Valle" };
            var product559 = new Product { Id = 559, Code = "202010", Name = "Anón Común" };
            var product560 = new Product { Id = 560, Code = "202020", Name = "Arazá" };
            var product561 = new Product { Id = 561, Code = "204010", Name = "Banano verde" };
            var product562 = new Product { Id = 562, Code = "204045", Name = "Banano urabá exportación" };
            var product563 = new Product { Id = 563, Code = "204050", Name = "Banano verde Ciénaga" };
            var product564 = new Product { Id = 564, Code = "207010", Name = "Ciruela amarilla" };
            var product565 = new Product { Id = 565, Code = "207030", Name = "Ciruela negra americana" };
            var product566 = new Product { Id = 566, Code = "208020", Name = "Coco importado" };
            var product567 = new Product { Id = 567, Code = "209030", Name = "Curuba ecuatoriana" };
            var product568 = new Product { Id = 568, Code = "209070", Name = "Curuba SanBernardo-deCastil" };
            var product569 = new Product { Id = 569, Code = "209200", Name = "Chirimoya" };
            var product570 = new Product { Id = 570, Code = "209210", Name = "Chulupa" };
            var product571 = new Product { Id = 571, Code = "209215", Name = "Cholupa" };
            var product572 = new Product { Id = 572, Code = "210020", Name = "Durazno venezolano" };
            var product573 = new Product { Id = 573, Code = "210030", Name = "Durazno melocotón" };
            var product574 = new Product { Id = 574, Code = "212020", Name = "Granadilla urrao" };
            var product575 = new Product { Id = 575, Code = "212030", Name = "Granadilla valluna" };
            var product576 = new Product { Id = 576, Code = "212040", Name = "Granadilla huilense" };
            var product577 = new Product { Id = 577, Code = "213010", Name = "Guama" };
            var product578 = new Product { Id = 578, Code = "214020", Name = "Guanábana citrica" };
            var product579 = new Product { Id = 579, Code = "215040", Name = "Guayaba dulce" };
            var product580 = new Product { Id = 580, Code = "215050", Name = "Guayaba Magdalena" };
            var product581 = new Product { Id = 581, Code = "218050", Name = "Limón dulce" };
            var product582 = new Product { Id = 582, Code = "218070", Name = "Limón tahití bumanguesa" };
            var product583 = new Product { Id = 583, Code = "219020", Name = "Lulo ecuatoriano" };
            var product584 = new Product { Id = 584, Code = "219030", Name = "Lulo Sierra Nevada" };
            var product585 = new Product { Id = 585, Code = "222010", Name = "Mango" };
            var product586 = new Product { Id = 586, Code = "222030", Name = "Mango chancleto" };
            var product587 = new Product { Id = 587, Code = "222090", Name = "Manga" };
            var product588 = new Product { Id = 588, Code = "223070", Name = "Manzana roja americana" };
            var product589 = new Product { Id = 589, Code = "223075", Name = "Manzana roja chilena" };
            var product590 = new Product { Id = 590, Code = "223080", Name = "Manzana verde americana" };
            var product591 = new Product { Id = 591, Code = "223085", Name = "Manzana verde chilena" };
            var product592 = new Product { Id = 592, Code = "224020", Name = "Maracuyá monteriano" };
            var product593 = new Product { Id = 593, Code = "224040", Name = "Maracuyá ecuatoriano" };
            var product594 = new Product { Id = 594, Code = "225010", Name = "Melón" };
            var product595 = new Product { Id = 595, Code = "225030", Name = "Melón valluno" };
            var product596 = new Product { Id = 596, Code = "225040", Name = "Melón amarillo" };
            var product597 = new Product { Id = 597, Code = "226020", Name = "Mora ceja" };
            var product598 = new Product { Id = 598, Code = "226030", Name = "Mora pantanillo" };
            var product599 = new Product { Id = 599, Code = "228070", Name = "Toronja" };
            var product600 = new Product { Id = 600, Code = "228091", Name = "Tangelo llanero" };
            var product601 = new Product { Id = 601, Code = "228092", Name = "Tangelo Eje Cafetero" };
            var product602 = new Product { Id = 602, Code = "228100", Name = "Tamarindo" };
            var product603 = new Product { Id = 603, Code = "233040", Name = "Pera verde" };
            var product604 = new Product { Id = 604, Code = "233050", Name = "Pera americana" };
            var product605 = new Product { Id = 605, Code = "233060", Name = "Pera chilena" };
            var product606 = new Product { Id = 606, Code = "238010", Name = "Tamarillo" };
            var product607 = new Product { Id = 607, Code = "238080", Name = "Uchuva" };
            var product608 = new Product { Id = 608, Code = "239020", Name = "Uva champaña" };
            var product609 = new Product { Id = 609, Code = "239052", Name = "Uva roja americana" };
            var product610 = new Product { Id = 610, Code = "239054", Name = "Uva roja peruana" };
            var product611 = new Product { Id = 611, Code = "239070", Name = "Uva chilena" };
            var product612 = new Product { Id = 612, Code = "239075", Name = "Uva americana" };
            var product613 = new Product { Id = 613, Code = "240020", Name = "Zapote cachaco" };
            var product614 = new Product { Id = 614, Code = "240030", Name = "Zapote costeño" };
            var product615 = new Product { Id = 615, Code = "301050", Name = "Arracacha bumanguesa" };
            var product616 = new Product { Id = 616, Code = "301080", Name = "Arracacha Versalles" };
            var product617 = new Product { Id = 617, Code = "301100", Name = "Arracacha amarilla-Cajamarc" };
            var product618 = new Product { Id = 618, Code = "303010", Name = "Batata" };
            var product619 = new Product { Id = 619, Code = "303015", Name = "Jengibre" };
            var product620 = new Product { Id = 620, Code = "303020", Name = "Malanga" };
            var product621 = new Product { Id = 621, Code = "305010", Name = "Papa criolla bumanguesa" };
            var product622 = new Product { Id = 622, Code = "305055", Name = "Papa Chitagá blanca" };
            var product623 = new Product { Id = 623, Code = "305100", Name = "Papa gualcala" };
            var product624 = new Product { Id = 624, Code = "305140", Name = "Papa ICA morasurco" };
            var product625 = new Product { Id = 625, Code = "305152", Name = "Papa parda" };
            var product626 = new Product { Id = 626, Code = "305154", Name = "Papa parda ipialeña" };
            var product627 = new Product { Id = 627, Code = "305190", Name = "Papa carriza" };
            var product628 = new Product { Id = 628, Code = "305220", Name = "Papa sabanera para lavar" };
            var product629 = new Product { Id = 629, Code = "305242", Name = "Papa ICA R-18" };
            var product630 = new Product { Id = 630, Code = "305245", Name = "Papa R-12 negra para lavar" };
            var product631 = new Product { Id = 631, Code = "305350", Name = "Papa San Felix" };
            var product632 = new Product { Id = 632, Code = "305390", Name = "Papa San Pedro" };
            var product633 = new Product { Id = 633, Code = "305400", Name = "Papa criolla pastusa" };
            var product634 = new Product { Id = 634, Code = "305420", Name = "Papa criolla richi" };
            var product635 = new Product { Id = 635, Code = "305442", Name = "Papa criolla manbera" };
            var product636 = new Product { Id = 636, Code = "306040", Name = "Plátano criollo" };
            var product637 = new Product { Id = 637, Code = "306060", Name = "Plátano dom.verd." };
            var product638 = new Product { Id = 638, Code = "306070", Name = "Plátano dom.hart.verd." };
            var product639 = new Product { Id = 639, Code = "306190", Name = "Plátano dom.hart.mad." };
            var product640 = new Product { Id = 640, Code = "306200", Name = "Plátano" };
            var product641 = new Product { Id = 641, Code = "307010", Name = "Ulluco caucano" };
            var product642 = new Product { Id = 642, Code = "307030", Name = "Ulluco ipialeño" };
            var product643 = new Product { Id = 643, Code = "307040", Name = "Ulluco pastuso" };
            var product644 = new Product { Id = 644, Code = "308070", Name = "Yuca chirosa valluna" };
            var product645 = new Product { Id = 645, Code = "308090", Name = "Yuca chirosa Armenia" };
            var product646 = new Product { Id = 646, Code = "402010", Name = "Arveja verde seca" };
            var product647 = new Product { Id = 647, Code = "404040", Name = "Cuchuco de trigo" };
            var product648 = new Product { Id = 648, Code = "405020", Name = "Fríjol balin" };
            var product649 = new Product { Id = 649, Code = "405050", Name = "Fríjol cabecita negra" };
            var product650 = new Product { Id = 650, Code = "405090", Name = "Fríjol caraota" };
            var product651 = new Product { Id = 651, Code = "405100", Name = "Fríjol cargamanto" };
            var product652 = new Product { Id = 652, Code = "405150", Name = "Fríjol palomito nacional" };
            var product653 = new Product { Id = 653, Code = "405180", Name = "Fríjol rojo sabanero" };
            var product654 = new Product { Id = 654, Code = "405190", Name = "Fríjol sangre toro" };
            var product655 = new Product { Id = 655, Code = "405220", Name = "Fríjol lima" };
            var product656 = new Product { Id = 656, Code = "405230", Name = "Fríjol cargamanto mocho" };
            var product657 = new Product { Id = 657, Code = "405240", Name = "Fríjol enlatado 300 g" };
            var product658 = new Product { Id = 658, Code = "405250", Name = "Fríjol enlatado 380 g" };
            var product659 = new Product { Id = 659, Code = "407010", Name = "Guandul" };
            var product660 = new Product { Id = 660, Code = "408030", Name = "Lenteja canadiense" };
            var product661 = new Product { Id = 661, Code = "409060", Name = "Maíz blanco duro" };
            var product662 = new Product { Id = 662, Code = "409100", Name = "Maíz para gallinas" };
            var product663 = new Product { Id = 663, Code = "409160", Name = "Maíz trillado peto" };
            var product664 = new Product { Id = 664, Code = "501010", Name = "Leche Pasteurizada 750 c.c" };
            var product665 = new Product { Id = 665, Code = "501030", Name = "Leche en polvo tarro 400 g" };
            var product666 = new Product { Id = 666, Code = "501050", Name = "Leche Pasteurizada 1000 c.c." };
            var product667 = new Product { Id = 667, Code = "501060", Name = "Leche en polvo bolsa 400 g" };
            var product668 = new Product { Id = 668, Code = "501061", Name = "Leche en polvo bolsa 360 g" };
            var product669 = new Product { Id = 669, Code = "501065", Name = "Leche en polvo bolsa 380 g" };
            var product670 = new Product { Id = 670, Code = "501070", Name = "Leche Fresca" };
            var product671 = new Product { Id = 671, Code = "502020", Name = "Queso 350 g" };
            var product672 = new Product { Id = 672, Code = "601010", Name = "Carne res en canal" };
            var product673 = new Product { Id = 673, Code = "601020", Name = "Carne res de 1ra" };
            var product674 = new Product { Id = 674, Code = "601030", Name = "Carne res de 2da" };
            var product675 = new Product { Id = 675, Code = "601040", Name = "Carne res sin hueso" };
            var product676 = new Product { Id = 676, Code = "601050", Name = "Carne res revuelta" };
            var product677 = new Product { Id = 677, Code = "601060", Name = "Carne res lomo caracha" };
            var product678 = new Product { Id = 678, Code = "601070", Name = "Carne res lomo fino" };
            var product679 = new Product { Id = 679, Code = "601080", Name = "Carne res lomo redondo" };
            var product680 = new Product { Id = 680, Code = "601090", Name = "Carne de res, lomo viche" };
            var product681 = new Product { Id = 681, Code = "601100", Name = "Carne res molida" };
            var product682 = new Product { Id = 682, Code = "601125", Name = "Carne res morrillo" };
            var product683 = new Product { Id = 683, Code = "601130", Name = "Carne res punta de anca" };
            var product684 = new Product { Id = 684, Code = "601135", Name = "Carne res muchacho" };
            var product685 = new Product { Id = 685, Code = "601140", Name = "Carne res murillo" };
            var product686 = new Product { Id = 686, Code = "601145", Name = "Carne res bola de pierna" };
            var product687 = new Product { Id = 687, Code = "601150", Name = "Carne res centro de pierna" };
            var product688 = new Product { Id = 688, Code = "601155", Name = "Carne res bota" };
            var product689 = new Product { Id = 689, Code = "601160", Name = "Carne res sobrebarriga" };
            var product690 = new Product { Id = 690, Code = "601165", Name = "Carne res falda" };
            var product691 = new Product { Id = 691, Code = "601170", Name = "Carne res cogote" };
            var product692 = new Product { Id = 692, Code = "601175", Name = "Carne res pecho" };
            var product693 = new Product { Id = 693, Code = "601180", Name = "Carne res paletero" };
            var product694 = new Product { Id = 694, Code = "601185", Name = "Carne res lomo de brazo" };
            var product695 = new Product { Id = 695, Code = "601190", Name = "Carne res bola de brazo" };
            var product696 = new Product { Id = 696, Code = "602030", Name = "Gallina ponedora de descarte" };
            var product697 = new Product { Id = 697, Code = "602035", Name = "Gallina repro. de descarte" };
            var product698 = new Product { Id = 698, Code = "603010", Name = "Carne cerdo en canal" };
            var product699 = new Product { Id = 699, Code = "603030", Name = "Carne cerdo sin hueso" };
            var product700 = new Product { Id = 700, Code = "603045", Name = "Carne cerdo brazo con hueso" };
            var product701 = new Product { Id = 701, Code = "603050", Name = "Carne cerdo costilla" };
            var product702 = new Product { Id = 702, Code = "603060", Name = "Carne cerdo lomo" };
            var product703 = new Product { Id = 703, Code = "603065", Name = "Carne cerdo lomo con hueso" };
            var product704 = new Product { Id = 704, Code = "603070", Name = "Carne cerdo tocino" };
            var product705 = new Product { Id = 705, Code = "603075", Name = "Carne cerdo tocino papada" };
            var product706 = new Product { Id = 706, Code = "603081", Name = "Carne cerdo tocino barriga" };
            var product707 = new Product { Id = 707, Code = "603082", Name = "Carne cerdo cabeza de lomo" };
            var product708 = new Product { Id = 708, Code = "603084", Name = "Carne cerdo espinazo" };
            var product709 = new Product { Id = 709, Code = "603086", Name = "Carne cerdo pernil sin hues" };
            var product710 = new Product { Id = 710, Code = "603088", Name = "Carne cerdo pernil con hues" };
            var product711 = new Product { Id = 711, Code = "603090", Name = "Carne cerdo tocineta planch" };
            var product712 = new Product { Id = 712, Code = "603092", Name = "Carne cerdo chuleta de lomo" };
            var product713 = new Product { Id = 713, Code = "604010", Name = "Pescado mojarra entero" };
            var product714 = new Product { Id = 714, Code = "604011", Name = "Pescado mojarra de mar" };
            var product715 = new Product { Id = 715, Code = "604012", Name = "Pescado mojarra lora" };
            var product716 = new Product { Id = 716, Code = "604015", Name = "Pescado cachama" };
            var product717 = new Product { Id = 717, Code = "604018", Name = "Pescado pargo rojo rodajas" };
            var product718 = new Product { Id = 718, Code = "604020", Name = "Pescado pargo rojo entero" };
            var product719 = new Product { Id = 719, Code = "604025", Name = "Pescado pargo rojo platero" };
            var product720 = new Product { Id = 720, Code = "604028", Name = "Pescado nicuro" };
            var product721 = new Product { Id = 721, Code = "604030", Name = "Pescado trucha entero" };
            var product722 = new Product { Id = 722, Code = "604032", Name = "Pescado tilapia entero" };
            var product723 = new Product { Id = 723, Code = "604034", Name = "Pescado trucha arco iris" };
            var product724 = new Product { Id = 724, Code = "604036", Name = "Pescado trucha importada" };
            var product725 = new Product { Id = 725, Code = "604038", Name = "Trucha corte mariposa" };
            var product726 = new Product { Id = 726, Code = "604040", Name = "Pescado bagre" };
            var product727 = new Product { Id = 727, Code = "604042", Name = "Pescado cherna" };
            var product728 = new Product { Id = 728, Code = "604044", Name = "Pescado filete de cherna" };
            var product729 = new Product { Id = 729, Code = "604046", Name = "Pescado atún entero" };
            var product730 = new Product { Id = 730, Code = "604050", Name = "Pescado bocachico" };
            var product731 = new Product { Id = 731, Code = "604051", Name = "Pescado alguacil" };
            var product732 = new Product { Id = 732, Code = "604053", Name = "Pescado bocachico criollo" };
            var product733 = new Product { Id = 733, Code = "604054", Name = "Pescado bocachico importado" };
            var product734 = new Product { Id = 734, Code = "604057", Name = "Pescado jurel" };
            var product735 = new Product { Id = 735, Code = "604058", Name = "Pescado lebranche" };
            var product736 = new Product { Id = 736, Code = "604060", Name = "Pescado filete róbalo" };
            var product737 = new Product { Id = 737, Code = "604062", Name = "Pescado róbalo entero" };
            var product738 = new Product { Id = 738, Code = "604065", Name = "Pescado ñato" };
            var product739 = new Product { Id = 739, Code = "604068", Name = "Pescado corvina entero" };
            var product740 = new Product { Id = 740, Code = "604070", Name = "Pescado filete merluza" };
            var product741 = new Product { Id = 741, Code = "604072", Name = "Pescado filete corvina" };
            var product742 = new Product { Id = 742, Code = "604074", Name = "Pescado filete tollo" };
            var product743 = new Product { Id = 743, Code = "604076", Name = "Pescado tollo tinto entero" };
            var product744 = new Product { Id = 744, Code = "604078", Name = "Pescado tollo blanco entero" };
            var product745 = new Product { Id = 745, Code = "604080", Name = "Pescado camarón crudo" };
            var product746 = new Product { Id = 746, Code = "604081", Name = "Pescado camarón crudo tigre" };
            var product747 = new Product { Id = 747, Code = "604082", Name = "Pescado filete tollo blanco" };
            var product748 = new Product { Id = 748, Code = "604084", Name = "Pescado camarón crudo blanc" };
            var product749 = new Product { Id = 749, Code = "604086", Name = "Pescado camarón crudo tití" };
            var product750 = new Product { Id = 750, Code = "604100", Name = "Pescado camarón prec." };
            var product751 = new Product { Id = 751, Code = "604102", Name = "Pescado camarón prec. tigre" };
            var product752 = new Product { Id = 752, Code = "604106", Name = "Pescado camarón prec. tití" };
            var product753 = new Product { Id = 753, Code = "604110", Name = "Pescado caz. mariscos" };
            var product754 = new Product { Id = 754, Code = "604112", Name = "Pescado sardinata" };
            var product755 = new Product { Id = 755, Code = "604120", Name = "Pescado seco" };
            var product756 = new Product { Id = 756, Code = "604122", Name = "Pescado capaz" };
            var product757 = new Product { Id = 757, Code = "604124", Name = "Pescado filete dorado" };
            var product758 = new Product { Id = 758, Code = "604126", Name = "Pescado dorado entero" };
            var product759 = new Product { Id = 759, Code = "604128", Name = "Pescado filete tollo tinto" };
            var product760 = new Product { Id = 760, Code = "604130", Name = "Sardinas" };
            var product761 = new Product { Id = 761, Code = "604134", Name = "Pescado picuda" };
            var product762 = new Product { Id = 762, Code = "604138", Name = "Cabezas de pescado" };
            var product763 = new Product { Id = 763, Code = "604140", Name = "Pescado fil.merluza importa" };
            var product764 = new Product { Id = 764, Code = "604144", Name = "Pescado macarella" };
            var product765 = new Product { Id = 765, Code = "604148", Name = "Pescado sierra entero" };
            var product766 = new Product { Id = 766, Code = "604150", Name = "Sardinas vancamps" };
            var product767 = new Product { Id = 767, Code = "604152", Name = "Pescado pelada entero" };
            var product768 = new Product { Id = 768, Code = "604156", Name = "Pescado pescadilla" };
            var product769 = new Product { Id = 769, Code = "604160", Name = "Pescado bagre mar entero" };
            var product770 = new Product { Id = 770, Code = "604164", Name = "Pescado bagre mar rodajas" };
            var product771 = new Product { Id = 771, Code = "604166", Name = "Pescado bagre rio rodajas" };
            var product772 = new Product { Id = 772, Code = "604168", Name = "Pescado bagre rio entero" };
            var product773 = new Product { Id = 773, Code = "604170", Name = "Atún Vancamps" };
            var product774 = new Product { Id = 774, Code = "604185", Name = "Atún Burique" };
            var product775 = new Product { Id = 775, Code = "704060", Name = "Panela redonda blanca" };
            var product776 = new Product { Id = 776, Code = "704070", Name = "Panela redonda valluna" };
            var product777 = new Product { Id = 777, Code = "704080", Name = "Panelón" };
            var product778 = new Product { Id = 778, Code = "704110", Name = "Panela emp.termoenc." };
            var product779 = new Product { Id = 779, Code = "704120", Name = "Panela regional" };
            var product780 = new Product { Id = 780, Code = "801010", Name = "Aceite 500 c.c" };
            var product781 = new Product { Id = 781, Code = "801020", Name = "Aceite 1000 c.c" };
            var product782 = new Product { Id = 782, Code = "801080", Name = "Aceite de soya 1000 c.c." };
            var product783 = new Product { Id = 783, Code = "801100", Name = "Aceite 900 c.c." };
            var product784 = new Product { Id = 784, Code = "802010", Name = "Avena 400 g" };
            var product785 = new Product { Id = 785, Code = "802015", Name = "Avena hoj. bolsa 200 g" };
            var product786 = new Product { Id = 786, Code = "802060", Name = "Avena hoj. bolsa 1000 g" };
            var product787 = new Product { Id = 787, Code = "804010", Name = "Bocadillo C." };
            var product788 = new Product { Id = 788, Code = "805010", Name = "Café" };
            var product789 = new Product { Id = 789, Code = "805040", Name = "Café inst frasco 85 g" };
            var product790 = new Product { Id = 790, Code = "806010", Name = "Cebada perlada" };
            var product791 = new Product { Id = 791, Code = "807030", Name = "Chocolate 250 g" };
            var product792 = new Product { Id = 792, Code = "807070", Name = "Chocolate inst tarro 300 g" };
            var product793 = new Product { Id = 793, Code = "810010", Name = "Haruna de Arroz" };
            var product794 = new Product { Id = 794, Code = "810020", Name = "Harina de maíz" };
            var product795 = new Product { Id = 795, Code = "810050", Name = "Fécula de maíz 400 g" };
            var product796 = new Product { Id = 796, Code = "810055", Name = "Fécula de maíz 90 g" };
            var product797 = new Product { Id = 797, Code = "810080", Name = "Harina de trigo importada" };
            var product798 = new Product { Id = 798, Code = "810100", Name = "Harina para arepa" };
            var product799 = new Product { Id = 799, Code = "811020", Name = "Jugo instantáneo sobre 1,5" };
            var product800 = new Product { Id = 800, Code = "811030", Name = "Jugo instantáneo sobre 2 li" };
            var product801 = new Product { Id = 801, Code = "812020", Name = "Manteca Frida" };
            var product802 = new Product { Id = 802, Code = "813010", Name = "Mantequilla" };
            var product803 = new Product { Id = 803, Code = "814010", Name = "Margarina r. 250 g" };
            var product804 = new Product { Id = 804, Code = "815010", Name = "Mayonesa" };
            var product805 = new Product { Id = 805, Code = "815020", Name = "Mayonesa doy pack 200 g" };
            var product806 = new Product { Id = 806, Code = "815030", Name = "Mayonesa doy pack 400 g" };
            var product807 = new Product { Id = 807, Code = "818030", Name = "Salsa tomate doy pack 200 g" };
            var product808 = new Product { Id = 808, Code = "818040", Name = "Salsa tomate doy pack 400 g" };
            var product809 = new Product { Id = 809, Code = "819020", Name = "Pulpa de mora" };
            var product810 = new Product { Id = 810, Code = "819025", Name = "Pulpa de mango" };
            var product811 = new Product { Id = 811, Code = "819030", Name = "Pulpa de lulo" };
            var product812 = new Product { Id = 812, Code = "820020", Name = "Ajo molido bolsita 60 g" };
            var product813 = new Product { Id = 813, Code = "821010", Name = "Color Bolsita 125 g" };
            var product814 = new Product { Id = 814, Code = "821020", Name = "Color Bolsita 60 g" };
            var product815 = new Product { Id = 815, Code = "821030", Name = "Color Bolsita 70 g" };
            var product816 = new Product { Id = 816, Code = "830010", Name = "Sopa pollo caja 3 porciones" };
            var product817 = new Product { Id = 817, Code = "830020", Name = "Sopa pollo caja 6 porciones" };


            context.Products.AddOrUpdate(
                p => p.Id,
                product1,
                product2,
                product3,
                product4,
                product5,
                product6,
                product7,
                product8,
                product9,
                product10,
                product11,
                product12,
                product13,
                product14,
                product15,
                product16,
                product17,
                product18,
                product19,
                product20,
                product21,
                product22,
                product23,
                product24,
                product25,
                product26,
                product27,
                product28,
                product29,
                product30,
                product31,
                product32,
                product33,
                product34,
                product35,
                product36,
                product37,
                product38,
                product39,
                product40,
                product41,
                product42,
                product43,
                product44,
                product45,
                product46,
                product47,
                product48,
                product49,
                product50,
                product51,
                product52,
                product53,
                product54,
                product55,
                product56,
                product57,
                product58,
                product59,
                product60,
                product61,
                product62,
                product63,
                product64,
                product65,
                product66,
                product67,
                product68,
                product69,
                product70,
                product71,
                product72,
                product73,
                product74,
                product75,
                product76,
                product77,
                product78,
                product79,
                product80,
                product81,
                product82,
                product83,
                product84,
                product85,
                product86,
                product87,
                product88,
                product89,
                product90,
                product91,
                product92,
                product93,
                product94,
                product95,
                product96,
                product97,
                product98,
                product99,
                product100,
                product101,
                product102,
                product103,
                product104,
                product105,
                product106,
                product107,
                product108,
                product109,
                product110,
                product111,
                product112,
                product113,
                product114,
                product115,
                product116,
                product117,
                product118,
                product119,
                product120,
                product121,
                product122,
                product123,
                product124,
                product125,
                product126,
                product127,
                product128,
                product129,
                product130,
                product131,
                product132,
                product133,
                product134,
                product135,
                product136,
                product137,
                product138,
                product139,
                product140,
                product141,
                product142,
                product143,
                product144,
                product145,
                product146,
                product147,
                product148,
                product149,
                product150,
                product151,
                product152,
                product153,
                product154,
                product155,
                product156,
                product157,
                product158,
                product159,
                product160,
                product161,
                product162,
                product163,
                product164,
                product165,
                product166,
                product167,
                product168,
                product169,
                product170,
                product171,
                product172,
                product173,
                product174,
                product175,
                product176,
                product177,
                product178,
                product179,
                product180,
                product181,
                product182,
                product183,
                product184,
                product185,
                product186,
                product187,
                product188,
                product189,
                product190,
                product191,
                product192,
                product193,
                product194,
                product195,
                product196,
                product197,
                product198,
                product199,
                product200,
                product201,
                product202,
                product203,
                product204,
                product205,
                product206,
                product207,
                product208,
                product209,
                product210,
                product211,
                product212,
                product213,
                product214,
                product215,
                product216,
                product217,
                product218,
                product219,
                product220,
                product221,
                product222,
                product223,
                product224,
                product225,
                product226,
                product227,
                product228,
                product229,
                product230,
                product231,
                product232,
                product233,
                product234,
                product235,
                product236,
                product237,
                product238,
                product239,
                product240,
                product241,
                product242,
                product243,
                product244,
                product245,
                product246,
                product247,
                product248,
                product249,
                product250,
                product251,
                product252,
                product253,
                product254,
                product255,
                product256,
                product257,
                product258,
                product259,
                product260,
                product261,
                product262,
                product263,
                product264,
                product265,
                product266,
                product267,
                product268,
                product269,
                product270,
                product271,
                product272,
                product273,
                product274,
                product275,
                product276,
                product277,
                product278,
                product279,
                product280,
                product281,
                product282,
                product283,
                product284,
                product285,
                product286,
                product287,
                product288,
                product289,
                product290,
                product291,
                product292,
                product293,
                product294,
                product295,
                product296,
                product297,
                product298,
                product299,
                product300,
                product301,
                product302,
                product303,
                product304,
                product305,
                product306,
                product307,
                product308,
                product309,
                product310,
                product311,
                product312,
                product313,
                product314,
                product315,
                product316,
                product317,
                product318,
                product319,
                product320,
                product321,
                product322,
                product323,
                product324,
                product325,
                product326,
                product327,
                product328,
                product329,
                product330,
                product331,
                product332,
                product333,
                product334,
                product335,
                product336,
                product337,
                product338,
                product339,
                product340,
                product341,
                product342,
                product343,
                product344,
                product345,
                product346,
                product347,
                product348,
                product349,
                product350,
                product351,
                product352,
                product353,
                product354,
                product355,
                product356,
                product357,
                product358,
                product359,
                product360,
                product361,
                product362,
                product363,
                product364,
                product365,
                product366,
                product367,
                product368,
                product369,
                product370,
                product371,
                product372,
                product373,
                product374,
                product375,
                product376,
                product377,
                product378,
                product379,
                product380,
                product381,
                product382,
                product383,
                product384,
                product385,
                product386,
                product387,
                product388,
                product389,
                product390,
                product391,
                product392,
                product393,
                product394,
                product395,
                product396,
                product397,
                product398,
                product399,
                product400,
                product401,
                product402,
                product403,
                product404,
                product405,
                product406,
                product407,
                product408,
                product409,
                product410,
                product411,
                product412,
                product413,
                product414,
                product415,
                product416,
                product417,
                product418,
                product419,
                product420,
                product421,
                product422,
                product423,
                product424,
                product425,
                product426,
                product427,
                product428,
                product429,
                product430,
                product431,
                product432,
                product433,
                product434,
                product435,
                product436,
                product437,
                product438,
                product439,
                product440,
                product441,
                product442,
                product443,
                product444,
                product445,
                product446,
                product447,
                product448,
                product449,
                product450,
                product451,
                product452,
                product453,
                product454,
                product455,
                product456,
                product457,
                product458,
                product459,
                product460,
                product461,
                product462,
                product463,
                product464,
                product465,
                product466,
                product467,
                product468,
                product469,
                product470,
                product471,
                product472,
                product473,
                product474,
                product475,
                product476,
                product477,
                product478,
                product479,
                product480,
                product481,
                product482,
                product483,
                product484,
                product485,
                product486,
                product487,
                product488,
                product489,
                product490,
                product491,
                product492,
                product493,
                product494,
                product495,
                product496,
                product497,
                product498,
                product499,
                product500,
                product501,
                product502,
                product503,
                product504,
                product505,
                product506,
                product507,
                product508,
                product509,
                product510,
                product511,
                product512,
                product513,
                product514,
                product515,
                product516,
                product517,
                product518,
                product519,
                product520,
                product521,
                product522,
                product523,
                product524,
                product525,
                product526,
                product527,
                product528,
                product529,
                product530,
                product531,
                product532,
                product533,
                product534,
                product535,
                product536,
                product537,
                product538,
                product539,
                product540,
                product541,
                product542,
                product543,
                product544,
                product545,
                product546,
                product547,
                product548,
                product549,
                product550,
                product551,
                product552,
                product553,
                product554,
                product555,
                product556,
                product557,
                product558,
                product559,
                product560,
                product561,
                product562,
                product563,
                product564,
                product565,
                product566,
                product567,
                product568,
                product569,
                product570,
                product571,
                product572,
                product573,
                product574,
                product575,
                product576,
                product577,
                product578,
                product579,
                product580,
                product581,
                product582,
                product583,
                product584,
                product585,
                product586,
                product587,
                product588,
                product589,
                product590,
                product591,
                product592,
                product593,
                product594,
                product595,
                product596,
                product597,
                product598,
                product599,
                product600,
                product601,
                product602,
                product603,
                product604,
                product605,
                product606,
                product607,
                product608,
                product609,
                product610,
                product611,
                product612,
                product613,
                product614,
                product615,
                product616,
                product617,
                product618,
                product619,
                product620,
                product621,
                product622,
                product623,
                product624,
                product625,
                product626,
                product627,
                product628,
                product629,
                product630,
                product631,
                product632,
                product633,
                product634,
                product635,
                product636,
                product637,
                product638,
                product639,
                product640,
                product641,
                product642,
                product643,
                product644,
                product645,
                product646,
                product647,
                product648,
                product649,
                product650,
                product651,
                product652,
                product653,
                product654,
                product655,
                product656,
                product657,
                product658,
                product659,
                product660,
                product661,
                product662,
                product663,
                product664,
                product665,
                product666,
                product667,
                product668,
                product669,
                product670,
                product671,
                product672,
                product673,
                product674,
                product675,
                product676,
                product677,
                product678,
                product679,
                product680,
                product681,
                product682,
                product683,
                product684,
                product685,
                product686,
                product687,
                product688,
                product689,
                product690,
                product691,
                product692,
                product693,
                product694,
                product695,
                product696,
                product697,
                product698,
                product699,
                product700,
                product701,
                product702,
                product703,
                product704,
                product705,
                product706,
                product707,
                product708,
                product709,
                product710,
                product711,
                product712,
                product713,
                product714,
                product715,
                product716,
                product717,
                product718,
                product719,
                product720,
                product721,
                product722,
                product723,
                product724,
                product725,
                product726,
                product727,
                product728,
                product729,
                product730,
                product731,
                product732,
                product733,
                product734,
                product735,
                product736,
                product737,
                product738,
                product739,
                product740,
                product741,
                product742,
                product743,
                product744,
                product745,
                product746,
                product747,
                product748,
                product749,
                product750,
                product751,
                product752,
                product753,
                product754,
                product755,
                product756,
                product757,
                product758,
                product759,
                product760,
                product761,
                product762,
                product763,
                product764,
                product765,
                product766,
                product767,
                product768,
                product769,
                product770,
                product771,
                product772,
                product773,
                product774,
                product775,
                product776,
                product777,
                product778,
                product779,
                product780,
                product781,
                product782,
                product783,
                product784,
                product785,
                product786,
                product787,
                product788,
                product789,
                product790,
                product791,
                product792,
                product793,
                product794,
                product795,
                product796,
                product797,
                product798,
                product799,
                product800,
                product801,
                product802,
                product803,
                product804,
                product805,
                product806,
                product807,
                product808,
                product809,
                product810,
                product811,
                product812,
                product813,
                product814,
                product815,
                product816,
                product817
            );

            context.Prices.AddOrUpdate(
                pr => pr.Id,
                new Price {Id = 1, Product = product3, Unit = unit3, PriceAvgPerUnit = 1936, PriceMaxPerUnit = 3000, PriceMinPerUnit = 1000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 2, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 3, Product = product3, Unit = unit3, PriceAvgPerUnit = 1240, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 4, Product = product3, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1100, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 5, Product = product3, Unit = unit3, PriceAvgPerUnit = 900, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 6, Product = product3, Unit = unit3, PriceAvgPerUnit = 2544, PriceMaxPerUnit = 3200, PriceMinPerUnit = 2000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 7, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 8, Product = product3, Unit = unit3, PriceAvgPerUnit = 2083, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 9, Product = product3, Unit = unit3, PriceAvgPerUnit = 2633, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 10, Product = product3, Unit = unit3, PriceAvgPerUnit = 576, PriceMaxPerUnit = 667, PriceMinPerUnit = 500, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 11, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 12, Product = product3, Unit = unit3, PriceAvgPerUnit = 2400, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2400, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 13, Product = product3, Unit = unit3, PriceAvgPerUnit = 2081, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 14, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 15, Product = product3, Unit = unit3, PriceAvgPerUnit = 1525, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 16, Product = product3, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1083, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 17, Product = product3, Unit = unit3, PriceAvgPerUnit = 1013, PriceMaxPerUnit = 1200, PriceMinPerUnit = 800, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 18, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 19, Product = product3, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 20, Product = product4, Unit = unit3, PriceAvgPerUnit = 2407, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2200, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 21, Product = product4, Unit = unit3, PriceAvgPerUnit = 933, PriceMaxPerUnit = 1250, PriceMinPerUnit = 750, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 22, Product = product4, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1500, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 23, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2667, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 24, Product = product4, Unit = unit3, PriceAvgPerUnit = 2350, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 25, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 26, Product = product4, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 27, Product = product4, Unit = unit3, PriceAvgPerUnit = 1833, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 28, Product = product4, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 29, Product = product4, Unit = unit3, PriceAvgPerUnit = 1778, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1333, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 30, Product = product4, Unit = unit3, PriceAvgPerUnit = 4667, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 31, Product = product13, Unit = unit3, PriceAvgPerUnit = 690, PriceMaxPerUnit = 714, PriceMinPerUnit = 643, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 32, Product = product14, Unit = unit3, PriceAvgPerUnit = 392, PriceMaxPerUnit = 400, PriceMinPerUnit = 367, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 33, Product = product14, Unit = unit3, PriceAvgPerUnit = 539, PriceMaxPerUnit = 567, PriceMinPerUnit = 500, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 34, Product = product14, Unit = unit3, PriceAvgPerUnit = 622, PriceMaxPerUnit = 633, PriceMinPerUnit = 600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 35, Product = product15, Unit = unit3, PriceAvgPerUnit = 525, PriceMaxPerUnit = 550, PriceMinPerUnit = 500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 36, Product = product15, Unit = unit3, PriceAvgPerUnit = 1111, PriceMaxPerUnit = 1111, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 37, Product = product15, Unit = unit3, PriceAvgPerUnit = 657, PriceMaxPerUnit = 900, PriceMinPerUnit = 500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 38, Product = product15, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 667, PriceMinPerUnit = 667, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 39, Product = product15, Unit = unit3, PriceAvgPerUnit = 394, PriceMaxPerUnit = 417, PriceMinPerUnit = 375, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 40, Product = product17, Unit = unit3, PriceAvgPerUnit = 883, PriceMaxPerUnit = 1000, PriceMinPerUnit = 786, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 41, Product = product17, Unit = unit3, PriceAvgPerUnit = 512, PriceMaxPerUnit = 560, PriceMinPerUnit = 480, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 42, Product = product17, Unit = unit3, PriceAvgPerUnit = 820, PriceMaxPerUnit = 840, PriceMinPerUnit = 800, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 43, Product = product17, Unit = unit3, PriceAvgPerUnit = 635, PriceMaxPerUnit = 680, PriceMinPerUnit = 600, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 44, Product = product17, Unit = unit3, PriceAvgPerUnit = 390, PriceMaxPerUnit = 440, PriceMinPerUnit = 340, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 45, Product = product17, Unit = unit3, PriceAvgPerUnit = 577, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 46, Product = product17, Unit = unit3, PriceAvgPerUnit = 680, PriceMaxPerUnit = 720, PriceMinPerUnit = 640, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 47, Product = product38, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 48, Product = product38, Unit = unit3, PriceAvgPerUnit = 1550, PriceMaxPerUnit = 1580, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 49, Product = product38, Unit = unit3, PriceAvgPerUnit = 1313, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 50, Product = product38, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 51, Product = product38, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2400, PriceMinPerUnit = 1600, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 52, Product = product38, Unit = unit3, PriceAvgPerUnit = 1573, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 53, Product = product39, Unit = unit3, PriceAvgPerUnit = 2758, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 54, Product = product40, Unit = unit3, PriceAvgPerUnit = 1738, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 55, Product = product40, Unit = unit3, PriceAvgPerUnit = 1600, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1500, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 56, Product = product40, Unit = unit3, PriceAvgPerUnit = 1950, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 57, Product = product40, Unit = unit3, PriceAvgPerUnit = 1725, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 58, Product = product40, Unit = unit3, PriceAvgPerUnit = 1920, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 59, Product = product40, Unit = unit3, PriceAvgPerUnit = 1788, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 60, Product = product40, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 61, Product = product40, Unit = unit3, PriceAvgPerUnit = 1406, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 62, Product = product40, Unit = unit3, PriceAvgPerUnit = 1808, PriceMaxPerUnit = 2100, PriceMinPerUnit = 1500, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 63, Product = product40, Unit = unit3, PriceAvgPerUnit = 1775, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 64, Product = product40, Unit = unit3, PriceAvgPerUnit = 1367, PriceMaxPerUnit = 1450, PriceMinPerUnit = 1300, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 65, Product = product40, Unit = unit3, PriceAvgPerUnit = 1478, PriceMaxPerUnit = 1650, PriceMinPerUnit = 1300, Location = "Peñol (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 66, Product = product40, Unit = unit3, PriceAvgPerUnit = 1704, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 67, Product = product40, Unit = unit3, PriceAvgPerUnit = 1375, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 68, Product = product40, Unit = unit3, PriceAvgPerUnit = 1263, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 69, Product = product55, Unit = unit3, PriceAvgPerUnit = 1583, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1500, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 70, Product = product55, Unit = unit3, PriceAvgPerUnit = 1919, PriceMaxPerUnit = 2033, PriceMinPerUnit = 1833, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 71, Product = product55, Unit = unit3, PriceAvgPerUnit = 1611, PriceMaxPerUnit = 1917, PriceMinPerUnit = 1333, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 72, Product = product56, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 882, PriceMinPerUnit = 824, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 73, Product = product56, Unit = unit3, PriceAvgPerUnit = 992, PriceMaxPerUnit = 1059, PriceMinPerUnit = 882, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 74, Product = product56, Unit = unit3, PriceAvgPerUnit = 523, PriceMaxPerUnit = 555, PriceMinPerUnit = 474, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 75, Product = product56, Unit = unit3, PriceAvgPerUnit = 967, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 76, Product = product56, Unit = unit3, PriceAvgPerUnit = 935, PriceMaxPerUnit = 1059, PriceMinPerUnit = 765, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 77, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 78, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 79, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 80, Product = product3, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 81, Product = product3, Unit = unit3, PriceAvgPerUnit = 2189, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 82, Product = product3, Unit = unit3, PriceAvgPerUnit = 4333, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 83, Product = product3, Unit = unit3, PriceAvgPerUnit = 4558, PriceMaxPerUnit = 4800, PriceMinPerUnit = 4400, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 84, Product = product3, Unit = unit3, PriceAvgPerUnit = 2633, PriceMaxPerUnit = 2933, PriceMinPerUnit = 2400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 85, Product = product3, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 86, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 87, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 88, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 89, Product = product3, Unit = unit3, PriceAvgPerUnit = 1833, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 90, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 91, Product = product3, Unit = unit3, PriceAvgPerUnit = 1475, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 92, Product = product3, Unit = unit3, PriceAvgPerUnit = 851, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 93, Product = product3, Unit = unit3, PriceAvgPerUnit = 674, PriceMaxPerUnit = 700, PriceMinPerUnit = 650, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 94, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 95, Product = product4, Unit = unit3, PriceAvgPerUnit = 2448, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 96, Product = product4, Unit = unit3, PriceAvgPerUnit = 4108, PriceMaxPerUnit = 4500, PriceMinPerUnit = 3700, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 97, Product = product4, Unit = unit3, PriceAvgPerUnit = 1483, PriceMaxPerUnit = 1750, PriceMinPerUnit = 1250, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 98, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2667, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 99, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 100, Product = product4, Unit = unit3, PriceAvgPerUnit = 2467, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 101, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 102, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 103, Product = product4, Unit = unit3, PriceAvgPerUnit = 3000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 2000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 104, Product = product4, Unit = unit3, PriceAvgPerUnit = 1444, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1333, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 105, Product = product4, Unit = unit3, PriceAvgPerUnit = 3396, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 106, Product = product13, Unit = unit3, PriceAvgPerUnit = 852, PriceMaxPerUnit = 1043, PriceMinPerUnit = 643, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 107, Product = product14, Unit = unit3, PriceAvgPerUnit = 561, PriceMaxPerUnit = 600, PriceMinPerUnit = 533, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 108, Product = product14, Unit = unit3, PriceAvgPerUnit = 558, PriceMaxPerUnit = 567, PriceMinPerUnit = 533, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 109, Product = product14, Unit = unit3, PriceAvgPerUnit = 417, PriceMaxPerUnit = 433, PriceMinPerUnit = 400, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 110, Product = product15, Unit = unit3, PriceAvgPerUnit = 748, PriceMaxPerUnit = 786, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 111, Product = product15, Unit = unit3, PriceAvgPerUnit = 1111, PriceMaxPerUnit = 1111, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 112, Product = product15, Unit = unit3, PriceAvgPerUnit = 1650, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1400, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 113, Product = product15, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 833, PriceMinPerUnit = 833, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 114, Product = product15, Unit = unit3, PriceAvgPerUnit = 308, PriceMaxPerUnit = 338, PriceMinPerUnit = 277, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 115, Product = product15, Unit = unit3, PriceAvgPerUnit = 265, PriceMaxPerUnit = 292, PriceMinPerUnit = 250, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 116, Product = product17, Unit = unit3, PriceAvgPerUnit = 744, PriceMaxPerUnit = 857, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 117, Product = product17, Unit = unit3, PriceAvgPerUnit = 780, PriceMaxPerUnit = 800, PriceMinPerUnit = 760, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 118, Product = product17, Unit = unit3, PriceAvgPerUnit = 567, PriceMaxPerUnit = 583, PriceMinPerUnit = 550, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 119, Product = product17, Unit = unit3, PriceAvgPerUnit = 1070, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 120, Product = product17, Unit = unit3, PriceAvgPerUnit = 707, PriceMaxPerUnit = 800, PriceMinPerUnit = 500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 121, Product = product17, Unit = unit3, PriceAvgPerUnit = 530, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 122, Product = product17, Unit = unit3, PriceAvgPerUnit = 731, PriceMaxPerUnit = 752, PriceMinPerUnit = 720, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 123, Product = product38, Unit = unit3, PriceAvgPerUnit = 1350, PriceMaxPerUnit = 1360, PriceMinPerUnit = 1320, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 124, Product = product38, Unit = unit3, PriceAvgPerUnit = 1683, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 125, Product = product38, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 126, Product = product38, Unit = unit3, PriceAvgPerUnit = 1600, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1600, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 127, Product = product38, Unit = unit3, PriceAvgPerUnit = 2080, PriceMaxPerUnit = 2240, PriceMinPerUnit = 1920, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 128, Product = product39, Unit = unit3, PriceAvgPerUnit = 2392, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 129, Product = product39, Unit = unit3, PriceAvgPerUnit = 2027, PriceMaxPerUnit = 2167, PriceMinPerUnit = 1800, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 130, Product = product40, Unit = unit3, PriceAvgPerUnit = 2052, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1900, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 131, Product = product40, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 132, Product = product40, Unit = unit3, PriceAvgPerUnit = 1705, PriceMaxPerUnit = 1720, PriceMinPerUnit = 1680, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 133, Product = product40, Unit = unit3, PriceAvgPerUnit = 2017, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 134, Product = product40, Unit = unit3, PriceAvgPerUnit = 1442, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 135, Product = product40, Unit = unit3, PriceAvgPerUnit = 1775, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 136, Product = product40, Unit = unit3, PriceAvgPerUnit = 1730, PriceMaxPerUnit = 1840, PriceMinPerUnit = 1600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 137, Product = product40, Unit = unit3, PriceAvgPerUnit = 1692, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 138, Product = product40, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1100, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 139, Product = product40, Unit = unit3, PriceAvgPerUnit = 1733, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 140, Product = product40, Unit = unit3, PriceAvgPerUnit = 1326, PriceMaxPerUnit = 1450, PriceMinPerUnit = 1200, Location = "Peñol (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 141, Product = product40, Unit = unit3, PriceAvgPerUnit = 1521, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 142, Product = product40, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 143, Product = product40, Unit = unit3, PriceAvgPerUnit = 1188, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1150, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 144, Product = product55, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 145, Product = product55, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 146, Product = product55, Unit = unit3, PriceAvgPerUnit = 1929, PriceMaxPerUnit = 2083, PriceMinPerUnit = 1833, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 147, Product = product56, Unit = unit3, PriceAvgPerUnit = 922, PriceMaxPerUnit = 1059, PriceMinPerUnit = 706, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 148, Product = product56, Unit = unit3, PriceAvgPerUnit = 694, PriceMaxPerUnit = 824, PriceMinPerUnit = 511, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 149, Product = product56, Unit = unit3, PriceAvgPerUnit = 785, PriceMaxPerUnit = 835, PriceMinPerUnit = 737, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 150, Product = product56, Unit = unit3, PriceAvgPerUnit = 808, PriceMaxPerUnit = 1000, PriceMinPerUnit = 600, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 151, Product = product56, Unit = unit3, PriceAvgPerUnit = 686, PriceMaxPerUnit = 733, PriceMinPerUnit = 633, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 152, Product = product3, Unit = unit3, PriceAvgPerUnit = 1093, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 153, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 154, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 155, Product = product3, Unit = unit3, PriceAvgPerUnit = 1050, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 156, Product = product3, Unit = unit3, PriceAvgPerUnit = 1300, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 157, Product = product3, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 158, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 159, Product = product3, Unit = unit3, PriceAvgPerUnit = 3517, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 160, Product = product3, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 161, Product = product3, Unit = unit3, PriceAvgPerUnit = 632, PriceMaxPerUnit = 667, PriceMinPerUnit = 500, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 162, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 163, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 164, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 165, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 166, Product = product3, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 167, Product = product3, Unit = unit3, PriceAvgPerUnit = 1042, PriceMaxPerUnit = 1167, PriceMinPerUnit = 917, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 168, Product = product3, Unit = unit3, PriceAvgPerUnit = 892, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 169, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 170, Product = product3, Unit = unit3, PriceAvgPerUnit = 4417, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 171, Product = product4, Unit = unit3, PriceAvgPerUnit = 2633, PriceMaxPerUnit = 3500, PriceMinPerUnit = 1800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 172, Product = product4, Unit = unit3, PriceAvgPerUnit = 1117, PriceMaxPerUnit = 1500, PriceMinPerUnit = 750, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 173, Product = product4, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 174, Product = product4, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1333, PriceMinPerUnit = 1000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 175, Product = product4, Unit = unit3, PriceAvgPerUnit = 3700, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3200, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 176, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 177, Product = product4, Unit = unit3, PriceAvgPerUnit = 5333, PriceMaxPerUnit = 6000, PriceMinPerUnit = 5000, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 178, Product = product4, Unit = unit3, PriceAvgPerUnit = 1667, PriceMaxPerUnit = 3000, PriceMinPerUnit = 1000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 179, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 180, Product = product4, Unit = unit3, PriceAvgPerUnit = 3333, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 181, Product = product4, Unit = unit3, PriceAvgPerUnit = 5417, PriceMaxPerUnit = 6000, PriceMinPerUnit = 4500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 182, Product = product13, Unit = unit3, PriceAvgPerUnit = 679, PriceMaxPerUnit = 714, PriceMinPerUnit = 643, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 183, Product = product14, Unit = unit3, PriceAvgPerUnit = 383, PriceMaxPerUnit = 400, PriceMinPerUnit = 367, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 184, Product = product14, Unit = unit3, PriceAvgPerUnit = 567, PriceMaxPerUnit = 567, PriceMinPerUnit = 567, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 185, Product = product15, Unit = unit3, PriceAvgPerUnit = 686, PriceMaxPerUnit = 714, PriceMinPerUnit = 643, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 186, Product = product15, Unit = unit3, PriceAvgPerUnit = 621, PriceMaxPerUnit = 750, PriceMinPerUnit = 550, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 187, Product = product15, Unit = unit3, PriceAvgPerUnit = 1111, PriceMaxPerUnit = 1111, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 188, Product = product15, Unit = unit3, PriceAvgPerUnit = 644, PriceMaxPerUnit = 875, PriceMinPerUnit = 467, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 189, Product = product15, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 667, PriceMinPerUnit = 667, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 190, Product = product15, Unit = unit3, PriceAvgPerUnit = 294, PriceMaxPerUnit = 308, PriceMinPerUnit = 283, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 191, Product = product17, Unit = unit3, PriceAvgPerUnit = 792, PriceMaxPerUnit = 857, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 192, Product = product17, Unit = unit3, PriceAvgPerUnit = 510, PriceMaxPerUnit = 560, PriceMinPerUnit = 480, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 193, Product = product17, Unit = unit3, PriceAvgPerUnit = 550, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 194, Product = product17, Unit = unit3, PriceAvgPerUnit = 635, PriceMaxPerUnit = 680, PriceMinPerUnit = 600, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 195, Product = product17, Unit = unit3, PriceAvgPerUnit = 487, PriceMaxPerUnit = 560, PriceMinPerUnit = 400, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 196, Product = product17, Unit = unit3, PriceAvgPerUnit = 575, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 197, Product = product17, Unit = unit3, PriceAvgPerUnit = 760, PriceMaxPerUnit = 800, PriceMinPerUnit = 720, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 198, Product = product38, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 199, Product = product38, Unit = unit3, PriceAvgPerUnit = 1208, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1100, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 200, Product = product38, Unit = unit3, PriceAvgPerUnit = 1488, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 201, Product = product38, Unit = unit3, PriceAvgPerUnit = 1875, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 202, Product = product38, Unit = unit3, PriceAvgPerUnit = 1540, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 203, Product = product38, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 204, Product = product39, Unit = unit3, PriceAvgPerUnit = 2804, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 205, Product = product40, Unit = unit3, PriceAvgPerUnit = 1818, PriceMaxPerUnit = 1900, PriceMinPerUnit = 1700, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 206, Product = product40, Unit = unit3, PriceAvgPerUnit = 1760, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 207, Product = product40, Unit = unit3, PriceAvgPerUnit = 2100, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 208, Product = product40, Unit = unit3, PriceAvgPerUnit = 1829, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 209, Product = product40, Unit = unit3, PriceAvgPerUnit = 1933, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1800, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 210, Product = product40, Unit = unit3, PriceAvgPerUnit = 1592, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 211, Product = product40, Unit = unit3, PriceAvgPerUnit = 1520, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 212, Product = product40, Unit = unit3, PriceAvgPerUnit = 1388, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 213, Product = product40, Unit = unit3, PriceAvgPerUnit = 1806, PriceMaxPerUnit = 2100, PriceMinPerUnit = 1700, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 214, Product = product40, Unit = unit3, PriceAvgPerUnit = 1414, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 215, Product = product40, Unit = unit3, PriceAvgPerUnit = 1389, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 216, Product = product40, Unit = unit3, PriceAvgPerUnit = 1528, PriceMaxPerUnit = 1850, PriceMinPerUnit = 1250, Location = "Peñol (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 217, Product = product40, Unit = unit3, PriceAvgPerUnit = 1227, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1200, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 218, Product = product40, Unit = unit3, PriceAvgPerUnit = 1379, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 219, Product = product40, Unit = unit3, PriceAvgPerUnit = 1488, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1450, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 220, Product = product55, Unit = unit3, PriceAvgPerUnit = 1361, PriceMaxPerUnit = 1583, PriceMinPerUnit = 1167, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 221, Product = product55, Unit = unit3, PriceAvgPerUnit = 1633, PriceMaxPerUnit = 1833, PriceMinPerUnit = 1433, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 222, Product = product55, Unit = unit3, PriceAvgPerUnit = 1799, PriceMaxPerUnit = 1917, PriceMinPerUnit = 1667, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 223, Product = product56, Unit = unit3, PriceAvgPerUnit = 868, PriceMaxPerUnit = 1059, PriceMinPerUnit = 778, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 224, Product = product56, Unit = unit3, PriceAvgPerUnit = 695, PriceMaxPerUnit = 941, PriceMinPerUnit = 529, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 225, Product = product56, Unit = unit3, PriceAvgPerUnit = 505, PriceMaxPerUnit = 555, PriceMinPerUnit = 474, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 226, Product = product56, Unit = unit3, PriceAvgPerUnit = 961, PriceMaxPerUnit = 1033, PriceMinPerUnit = 920, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 227, Product = product56, Unit = unit3, PriceAvgPerUnit = 694, PriceMaxPerUnit = 853, PriceMinPerUnit = 500, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 228, Product = product56, Unit = unit3, PriceAvgPerUnit = 590, PriceMaxPerUnit = 667, PriceMinPerUnit = 500, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 229, Product = product57, Unit = unit3, PriceAvgPerUnit = 790, PriceMaxPerUnit = 800, PriceMinPerUnit = 771, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 230, Product = product57, Unit = unit3, PriceAvgPerUnit = 458, PriceMaxPerUnit = 462, PriceMinPerUnit = 431, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 231, Product = product57, Unit = unit3, PriceAvgPerUnit = 408, PriceMaxPerUnit = 416, PriceMinPerUnit = 400, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 232, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 233, Product = product57, Unit = unit3, PriceAvgPerUnit = 515, PriceMaxPerUnit = 520, PriceMinPerUnit = 500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 234, Product = product57, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 235, Product = product57, Unit = unit3, PriceAvgPerUnit = 560, PriceMaxPerUnit = 560, PriceMinPerUnit = 560, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 236, Product = product57, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 237, Product = product57, Unit = unit3, PriceAvgPerUnit = 925, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 238, Product = product57, Unit = unit3, PriceAvgPerUnit = 500, PriceMaxPerUnit = 500, PriceMinPerUnit = 500, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 239, Product = product57, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 700, PriceMinPerUnit = 600, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 240, Product = product57, Unit = unit3, PriceAvgPerUnit = 650, PriceMaxPerUnit = 650, PriceMinPerUnit = 650, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 241, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 242, Product = product57, Unit = unit3, PriceAvgPerUnit = 600, PriceMaxPerUnit = 600, PriceMinPerUnit = 600, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 243, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 244, Product = product1, Unit = unit3, PriceAvgPerUnit = 493, PriceMaxPerUnit = 700, PriceMinPerUnit = 400, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 245, Product = product1, Unit = unit3, PriceAvgPerUnit = 880, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 246, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1333, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 247, Product = product1, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 248, Product = product1, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 249, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 250, Product = product1, Unit = unit3, PriceAvgPerUnit = 950, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 251, Product = product1, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 252, Product = product1, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 253, Product = product1, Unit = unit3, PriceAvgPerUnit = 1717, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 254, Product = product1, Unit = unit3, PriceAvgPerUnit = 740, PriceMaxPerUnit = 800, PriceMinPerUnit = 640, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 255, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 256, Product = product1, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 257, Product = product1, Unit = unit3, PriceAvgPerUnit = 3392, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3200, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 258, Product = product2, Unit = unit3, PriceAvgPerUnit = 716, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 259, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 260, Product = product2, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 261, Product = product2, Unit = unit3, PriceAvgPerUnit = 1180, PriceMaxPerUnit = 1280, PriceMinPerUnit = 1120, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 262, Product = product2, Unit = unit3, PriceAvgPerUnit = 1007, PriceMaxPerUnit = 1333, PriceMinPerUnit = 800, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 263, Product = product2, Unit = unit3, PriceAvgPerUnit = 1300, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1200, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 264, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 265, Product = product2, Unit = unit3, PriceAvgPerUnit = 1958, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 266, Product = product2, Unit = unit3, PriceAvgPerUnit = 889, PriceMaxPerUnit = 1000, PriceMinPerUnit = 833, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 267, Product = product2, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 268, Product = product2, Unit = unit3, PriceAvgPerUnit = 2200, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2200, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 269, Product = product2, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1000, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 270, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 271, Product = product2, Unit = unit3, PriceAvgPerUnit = 750, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 272, Product = product2, Unit = unit3, PriceAvgPerUnit = 926, PriceMaxPerUnit = 1176, PriceMinPerUnit = 706, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 273, Product = product2, Unit = unit3, PriceAvgPerUnit = 716, PriceMaxPerUnit = 765, PriceMinPerUnit = 647, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 274, Product = product2, Unit = unit3, PriceAvgPerUnit = 1076, PriceMaxPerUnit = 1440, PriceMinPerUnit = 960, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 275, Product = product9, Unit = unit3, PriceAvgPerUnit = 1767, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 276, Product = product10, Unit = unit3, PriceAvgPerUnit = 2800, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 277, Product = product10, Unit = unit3, PriceAvgPerUnit = 4800, PriceMaxPerUnit = 4800, PriceMinPerUnit = 4800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 278, Product = product10, Unit = unit3, PriceAvgPerUnit = 766, PriceMaxPerUnit = 1000, PriceMinPerUnit = 600, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 279, Product = product11, Unit = unit3, PriceAvgPerUnit = 2153, PriceMaxPerUnit = 2667, PriceMinPerUnit = 1667, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 280, Product = product11, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 281, Product = product11, Unit = unit3, PriceAvgPerUnit = 2667, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2667, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 282, Product = product11, Unit = unit3, PriceAvgPerUnit = 2167, PriceMaxPerUnit = 2333, PriceMinPerUnit = 2000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 283, Product = product11, Unit = unit3, PriceAvgPerUnit = 3200, PriceMaxPerUnit = 3200, PriceMinPerUnit = 3200, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 284, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 285, Product = product11, Unit = unit3, PriceAvgPerUnit = 2917, PriceMaxPerUnit = 3500, PriceMinPerUnit = 2500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 286, Product = product11, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 287, Product = product11, Unit = unit3, PriceAvgPerUnit = 3667, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 288, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 289, Product = product11, Unit = unit3, PriceAvgPerUnit = 3063, PriceMaxPerUnit = 3750, PriceMinPerUnit = 2500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 290, Product = product11, Unit = unit3, PriceAvgPerUnit = 3750, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 291, Product = product12, Unit = unit3, PriceAvgPerUnit = 956, PriceMaxPerUnit = 1000, PriceMinPerUnit = 929, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 292, Product = product12, Unit = unit3, PriceAvgPerUnit = 600, PriceMaxPerUnit = 600, PriceMinPerUnit = 600, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 293, Product = product12, Unit = unit3, PriceAvgPerUnit = 260, PriceMaxPerUnit = 260, PriceMinPerUnit = 260, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 294, Product = product12, Unit = unit3, PriceAvgPerUnit = 599, PriceMaxPerUnit = 643, PriceMinPerUnit = 571, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 295, Product = product12, Unit = unit3, PriceAvgPerUnit = 535, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 296, Product = product12, Unit = unit3, PriceAvgPerUnit = 1153, PriceMaxPerUnit = 1333, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 297, Product = product12, Unit = unit3, PriceAvgPerUnit = 346, PriceMaxPerUnit = 400, PriceMinPerUnit = 300, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 298, Product = product36, Unit = unit3, PriceAvgPerUnit = 2663, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2600, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 299, Product = product36, Unit = unit3, PriceAvgPerUnit = 1775, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 300, Product = product36, Unit = unit3, PriceAvgPerUnit = 2100, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 301, Product = product36, Unit = unit3, PriceAvgPerUnit = 2100, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 302, Product = product36, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 303, Product = product36, Unit = unit3, PriceAvgPerUnit = 1350, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 304, Product = product36, Unit = unit3, PriceAvgPerUnit = 2213, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 305, Product = product36, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1100, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 306, Product = product36, Unit = unit3, PriceAvgPerUnit = 2517, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 307, Product = product36, Unit = unit3, PriceAvgPerUnit = 2394, PriceMaxPerUnit = 2917, PriceMinPerUnit = 2000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 308, Product = product36, Unit = unit3, PriceAvgPerUnit = 2160, PriceMaxPerUnit = 2240, PriceMinPerUnit = 2000, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 309, Product = product36, Unit = unit3, PriceAvgPerUnit = 2400, PriceMaxPerUnit = 2560, PriceMinPerUnit = 2240, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 310, Product = product36, Unit = unit3, PriceAvgPerUnit = 2600, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2400, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 311, Product = product36, Unit = unit3, PriceAvgPerUnit = 2440, PriceMaxPerUnit = 2560, PriceMinPerUnit = 2400, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 312, Product = product36, Unit = unit3, PriceAvgPerUnit = 1837, PriceMaxPerUnit = 2240, PriceMinPerUnit = 1600, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 313, Product = product36, Unit = unit3, PriceAvgPerUnit = 2133, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 314, Product = product36, Unit = unit3, PriceAvgPerUnit = 1638, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 315, Product = product36, Unit = unit3, PriceAvgPerUnit = 2608, PriceMaxPerUnit = 3200, PriceMinPerUnit = 2100, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 316, Product = product36, Unit = unit3, PriceAvgPerUnit = 1656, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1500, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 317, Product = product36, Unit = unit3, PriceAvgPerUnit = 1733, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 318, Product = product36, Unit = unit3, PriceAvgPerUnit = 2558, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2200, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 319, Product = product36, Unit = unit3, PriceAvgPerUnit = 1425, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1200, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 320, Product = product36, Unit = unit3, PriceAvgPerUnit = 1569, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1500, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 321, Product = product36, Unit = unit3, PriceAvgPerUnit = 4833, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 322, Product = product43, Unit = unit3, PriceAvgPerUnit = 1950, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 323, Product = product43, Unit = unit3, PriceAvgPerUnit = 2204, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 324, Product = product55, Unit = unit3, PriceAvgPerUnit = 1708, PriceMaxPerUnit = 1917, PriceMinPerUnit = 1500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 325, Product = product55, Unit = unit3, PriceAvgPerUnit = 1667, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1667, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 326, Product = product55, Unit = unit3, PriceAvgPerUnit = 1650, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1633, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 327, Product = product55, Unit = unit3, PriceAvgPerUnit = 1823, PriceMaxPerUnit = 2333, PriceMinPerUnit = 1333, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 328, Product = product55, Unit = unit3, PriceAvgPerUnit = 1667, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1667, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 329, Product = product68, Unit = unit3, PriceAvgPerUnit = 889, PriceMaxPerUnit = 1083, PriceMinPerUnit = 833, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 330, Product = product68, Unit = unit3, PriceAvgPerUnit = 1150, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 331, Product = product68, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 867, PriceMinPerUnit = 800, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 332, Product = product68, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 333, Product = product68, Unit = unit3, PriceAvgPerUnit = 1387, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1120, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 334, Product = product68, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1100, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 335, Product = product68, Unit = unit3, PriceAvgPerUnit = 818, PriceMaxPerUnit = 880, PriceMinPerUnit = 800, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 336, Product = product7, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 900, PriceMinPerUnit = 700, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 337, Product = product7, Unit = unit3, PriceAvgPerUnit = 3700, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 338, Product = product7, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 339, Product = product8, Unit = unit3, PriceAvgPerUnit = 994, PriceMaxPerUnit = 1067, PriceMinPerUnit = 933, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 340, Product = product8, Unit = unit3, PriceAvgPerUnit = 987, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 341, Product = product8, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 342, Product = product8, Unit = unit3, PriceAvgPerUnit = 1150, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 343, Product = product8, Unit = unit3, PriceAvgPerUnit = 1513, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1400, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 344, Product = product8, Unit = unit3, PriceAvgPerUnit = 896, PriceMaxPerUnit = 1000, PriceMinPerUnit = 750, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 345, Product = product8, Unit = unit3, PriceAvgPerUnit = 969, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 346, Product = product8, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 347, Product = product8, Unit = unit3, PriceAvgPerUnit = 1147, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1120, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 348, Product = product8, Unit = unit3, PriceAvgPerUnit = 712, PriceMaxPerUnit = 769, PriceMinPerUnit = 615, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 349, Product = product8, Unit = unit3, PriceAvgPerUnit = 592, PriceMaxPerUnit = 769, PriceMinPerUnit = 462, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 350, Product = product8, Unit = unit3, PriceAvgPerUnit = 674, PriceMaxPerUnit = 833, PriceMinPerUnit = 583, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 351, Product = product8, Unit = unit3, PriceAvgPerUnit = 1486, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1333, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 352, Product = product8, Unit = unit3, PriceAvgPerUnit = 1141, PriceMaxPerUnit = 1417, PriceMinPerUnit = 1083, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 353, Product = product8, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1333, PriceMinPerUnit = 1167, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 354, Product = product8, Unit = unit3, PriceAvgPerUnit = 1236, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1167, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 355, Product = product8, Unit = unit3, PriceAvgPerUnit = 717, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 356, Product = product8, Unit = unit3, PriceAvgPerUnit = 1180, PriceMaxPerUnit = 1280, PriceMinPerUnit = 1120, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 357, Product = product8, Unit = unit3, PriceAvgPerUnit = 673, PriceMaxPerUnit = 769, PriceMinPerUnit = 615, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 358, Product = product8, Unit = unit3, PriceAvgPerUnit = 1150, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1000, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 359, Product = product8, Unit = unit3, PriceAvgPerUnit = 1147, PriceMaxPerUnit = 1280, PriceMinPerUnit = 1040, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 360, Product = product8, Unit = unit3, PriceAvgPerUnit = 949, PriceMaxPerUnit = 1154, PriceMinPerUnit = 769, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 361, Product = product8, Unit = unit3, PriceAvgPerUnit = 553, PriceMaxPerUnit = 625, PriceMinPerUnit = 429, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 362, Product = product8, Unit = unit3, PriceAvgPerUnit = 646, PriceMaxPerUnit = 800, PriceMinPerUnit = 500, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 363, Product = product18, Unit = unit3, PriceAvgPerUnit = 1793, PriceMaxPerUnit = 1880, PriceMinPerUnit = 1640, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 364, Product = product18, Unit = unit3, PriceAvgPerUnit = 1287, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 365, Product = product18, Unit = unit3, PriceAvgPerUnit = 1525, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 366, Product = product18, Unit = unit3, PriceAvgPerUnit = 1480, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1460, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 367, Product = product18, Unit = unit3, PriceAvgPerUnit = 1525, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 368, Product = product18, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 369, Product = product18, Unit = unit3, PriceAvgPerUnit = 2400, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2400, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 370, Product = product18, Unit = unit3, PriceAvgPerUnit = 1477, PriceMaxPerUnit = 1520, PriceMinPerUnit = 1400, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 371, Product = product18, Unit = unit3, PriceAvgPerUnit = 1558, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 372, Product = product18, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 373, Product = product18, Unit = unit3, PriceAvgPerUnit = 1455, PriceMaxPerUnit = 1520, PriceMinPerUnit = 1360, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 374, Product = product18, Unit = unit3, PriceAvgPerUnit = 1323, PriceMaxPerUnit = 1440, PriceMinPerUnit = 1200, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 375, Product = product18, Unit = unit3, PriceAvgPerUnit = 1553, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 376, Product = product18, Unit = unit3, PriceAvgPerUnit = 1582, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1500, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 377, Product = product18, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 378, Product = product18, Unit = unit3, PriceAvgPerUnit = 1613, PriceMaxPerUnit = 2080, PriceMinPerUnit = 1200, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 379, Product = product18, Unit = unit3, PriceAvgPerUnit = 1529, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 380, Product = product18, Unit = unit3, PriceAvgPerUnit = 1555, PriceMaxPerUnit = 1900, PriceMinPerUnit = 1250, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 381, Product = product18, Unit = unit3, PriceAvgPerUnit = 1967, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 382, Product = product18, Unit = unit3, PriceAvgPerUnit = 1582, PriceMaxPerUnit = 1708, PriceMinPerUnit = 1458, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 383, Product = product18, Unit = unit3, PriceAvgPerUnit = 1552, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1480, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 384, Product = product48, Unit = unit3, PriceAvgPerUnit = 2067, PriceMaxPerUnit = 2250, PriceMinPerUnit = 2000, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 385, Product = product48, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 386, Product = product48, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1750, PriceMinPerUnit = 1750, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 387, Product = product48, Unit = unit3, PriceAvgPerUnit = 2007, PriceMaxPerUnit = 2080, PriceMinPerUnit = 2000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 388, Product = product48, Unit = unit3, PriceAvgPerUnit = 2325, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 389, Product = product48, Unit = unit3, PriceAvgPerUnit = 1763, PriceMaxPerUnit = 1900, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 390, Product = product3, Unit = unit3, PriceAvgPerUnit = 3771, PriceMaxPerUnit = 4500, PriceMinPerUnit = 3000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 391, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 392, Product = product3, Unit = unit3, PriceAvgPerUnit = 1210, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 393, Product = product3, Unit = unit3, PriceAvgPerUnit = 1150, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 394, Product = product3, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 395, Product = product3, Unit = unit3, PriceAvgPerUnit = 2689, PriceMaxPerUnit = 3067, PriceMinPerUnit = 2333, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 396, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 397, Product = product3, Unit = unit3, PriceAvgPerUnit = 2125, PriceMaxPerUnit = 2300, PriceMinPerUnit = 2000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 398, Product = product3, Unit = unit3, PriceAvgPerUnit = 2633, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 399, Product = product3, Unit = unit3, PriceAvgPerUnit = 801, PriceMaxPerUnit = 1000, PriceMinPerUnit = 583, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 400, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 401, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 402, Product = product3, Unit = unit3, PriceAvgPerUnit = 2270, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 403, Product = product3, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 404, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 405, Product = product3, Unit = unit3, PriceAvgPerUnit = 1028, PriceMaxPerUnit = 1083, PriceMinPerUnit = 1000, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 406, Product = product3, Unit = unit3, PriceAvgPerUnit = 838, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 407, Product = product3, Unit = unit3, PriceAvgPerUnit = 674, PriceMaxPerUnit = 700, PriceMinPerUnit = 650, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 408, Product = product3, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 409, Product = product4, Unit = unit3, PriceAvgPerUnit = 3300, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 410, Product = product4, Unit = unit3, PriceAvgPerUnit = 2917, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2800, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 411, Product = product4, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 412, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2667, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 413, Product = product4, Unit = unit3, PriceAvgPerUnit = 4167, PriceMaxPerUnit = 4333, PriceMinPerUnit = 4000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 414, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 415, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 416, Product = product4, Unit = unit3, PriceAvgPerUnit = 5333, PriceMaxPerUnit = 6000, PriceMinPerUnit = 5000, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 417, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 418, Product = product4, Unit = unit3, PriceAvgPerUnit = 3000, PriceMaxPerUnit = 4667, PriceMinPerUnit = 1333, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 419, Product = product4, Unit = unit3, PriceAvgPerUnit = 5500, PriceMaxPerUnit = 6000, PriceMinPerUnit = 4500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 420, Product = product13, Unit = unit3, PriceAvgPerUnit = 738, PriceMaxPerUnit = 786, PriceMinPerUnit = 714, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 421, Product = product14, Unit = unit3, PriceAvgPerUnit = 542, PriceMaxPerUnit = 600, PriceMinPerUnit = 533, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 422, Product = product14, Unit = unit3, PriceAvgPerUnit = 375, PriceMaxPerUnit = 400, PriceMinPerUnit = 333, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 423, Product = product14, Unit = unit3, PriceAvgPerUnit = 611, PriceMaxPerUnit = 633, PriceMinPerUnit = 600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 424, Product = product15, Unit = unit3, PriceAvgPerUnit = 504, PriceMaxPerUnit = 550, PriceMinPerUnit = 425, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 425, Product = product15, Unit = unit3, PriceAvgPerUnit = 1190, PriceMaxPerUnit = 1389, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 426, Product = product15, Unit = unit3, PriceAvgPerUnit = 771, PriceMaxPerUnit = 875, PriceMinPerUnit = 667, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 427, Product = product15, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 667, PriceMinPerUnit = 667, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 428, Product = product15, Unit = unit3, PriceAvgPerUnit = 363, PriceMaxPerUnit = 385, PriceMinPerUnit = 308, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 429, Product = product3, Unit = unit3, PriceAvgPerUnit = 1363, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 430, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 431, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 432, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 433, Product = product3, Unit = unit3, PriceAvgPerUnit = 1350, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 434, Product = product3, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 435, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 436, Product = product3, Unit = unit3, PriceAvgPerUnit = 2492, PriceMaxPerUnit = 2600, PriceMinPerUnit = 2300, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 437, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 438, Product = product3, Unit = unit3, PriceAvgPerUnit = 604, PriceMaxPerUnit = 667, PriceMinPerUnit = 500, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 439, Product = product3, Unit = unit3, PriceAvgPerUnit = 2083, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 440, Product = product3, Unit = unit3, PriceAvgPerUnit = 1600, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1600, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 441, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 442, Product = product3, Unit = unit3, PriceAvgPerUnit = 1383, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1200, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 443, Product = product3, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 444, Product = product3, Unit = unit3, PriceAvgPerUnit = 1069, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1000, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 445, Product = product3, Unit = unit3, PriceAvgPerUnit = 621, PriceMaxPerUnit = 650, PriceMinPerUnit = 600, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 446, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 447, Product = product3, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 448, Product = product4, Unit = unit3, PriceAvgPerUnit = 3242, PriceMaxPerUnit = 3700, PriceMinPerUnit = 3000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 449, Product = product4, Unit = unit3, PriceAvgPerUnit = 2667, PriceMaxPerUnit = 3750, PriceMinPerUnit = 1250, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 450, Product = product4, Unit = unit3, PriceAvgPerUnit = 2188, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1750, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 451, Product = product4, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2333, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 452, Product = product4, Unit = unit3, PriceAvgPerUnit = 3667, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3200, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 453, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 454, Product = product4, Unit = unit3, PriceAvgPerUnit = 2333, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 455, Product = product4, Unit = unit3, PriceAvgPerUnit = 2667, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 456, Product = product4, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 457, Product = product4, Unit = unit3, PriceAvgPerUnit = 3333, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 458, Product = product4, Unit = unit3, PriceAvgPerUnit = 5125, PriceMaxPerUnit = 6000, PriceMinPerUnit = 4500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 459, Product = product14, Unit = unit3, PriceAvgPerUnit = 406, PriceMaxPerUnit = 467, PriceMinPerUnit = 333, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 460, Product = product14, Unit = unit3, PriceAvgPerUnit = 467, PriceMaxPerUnit = 533, PriceMinPerUnit = 400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 461, Product = product14, Unit = unit3, PriceAvgPerUnit = 561, PriceMaxPerUnit = 567, PriceMinPerUnit = 533, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 462, Product = product15, Unit = unit3, PriceAvgPerUnit = 714, PriceMaxPerUnit = 714, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 463, Product = product15, Unit = unit3, PriceAvgPerUnit = 671, PriceMaxPerUnit = 750, PriceMinPerUnit = 575, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 464, Product = product15, Unit = unit3, PriceAvgPerUnit = 1111, PriceMaxPerUnit = 1111, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 465, Product = product15, Unit = unit3, PriceAvgPerUnit = 609, PriceMaxPerUnit = 875, PriceMinPerUnit = 467, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 466, Product = product15, Unit = unit3, PriceAvgPerUnit = 449, PriceMaxPerUnit = 615, PriceMinPerUnit = 354, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 467, Product = product15, Unit = unit3, PriceAvgPerUnit = 381, PriceMaxPerUnit = 417, PriceMinPerUnit = 333, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 468, Product = product17, Unit = unit3, PriceAvgPerUnit = 814, PriceMaxPerUnit = 1000, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 469, Product = product3, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 470, Product = product3, Unit = unit3, PriceAvgPerUnit = 1193, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 471, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 472, Product = product3, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 473, Product = product3, Unit = unit3, PriceAvgPerUnit = 1778, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1667, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 474, Product = product3, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 475, Product = product3, Unit = unit3, PriceAvgPerUnit = 3525, PriceMaxPerUnit = 4600, PriceMinPerUnit = 2400, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 476, Product = product3, Unit = unit3, PriceAvgPerUnit = 2641, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 477, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 478, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 479, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 480, Product = product3, Unit = unit3, PriceAvgPerUnit = 2250, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 481, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 482, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 483, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 484, Product = product3, Unit = unit3, PriceAvgPerUnit = 1154, PriceMaxPerUnit = 1500, PriceMinPerUnit = 800, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 485, Product = product3, Unit = unit3, PriceAvgPerUnit = 676, PriceMaxPerUnit = 700, PriceMinPerUnit = 650, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 486, Product = product3, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 487, Product = product4, Unit = unit3, PriceAvgPerUnit = 3699, PriceMaxPerUnit = 5000, PriceMinPerUnit = 2500, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 488, Product = product4, Unit = unit3, PriceAvgPerUnit = 3850, PriceMaxPerUnit = 4200, PriceMinPerUnit = 3400, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 489, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 490, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2667, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 491, Product = product4, Unit = unit3, PriceAvgPerUnit = 4333, PriceMaxPerUnit = 4667, PriceMinPerUnit = 4000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 492, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 493, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 494, Product = product4, Unit = unit3, PriceAvgPerUnit = 5000, PriceMaxPerUnit = 5000, PriceMinPerUnit = 5000, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 495, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 496, Product = product4, Unit = unit3, PriceAvgPerUnit = 1889, PriceMaxPerUnit = 2667, PriceMinPerUnit = 1333, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 497, Product = product4, Unit = unit3, PriceAvgPerUnit = 3333, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 498, Product = product13, Unit = unit3, PriceAvgPerUnit = 714, PriceMaxPerUnit = 714, PriceMinPerUnit = 714, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 499, Product = product14, Unit = unit3, PriceAvgPerUnit = 535, PriceMaxPerUnit = 600, PriceMinPerUnit = 500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 500, Product = product14, Unit = unit3, PriceAvgPerUnit = 367, PriceMaxPerUnit = 367, PriceMinPerUnit = 367, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 501, Product = product14, Unit = unit3, PriceAvgPerUnit = 583, PriceMaxPerUnit = 600, PriceMinPerUnit = 567, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 502, Product = product15, Unit = unit3, PriceAvgPerUnit = 715, PriceMaxPerUnit = 786, PriceMinPerUnit = 643, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 503, Product = product15, Unit = unit3, PriceAvgPerUnit = 1111, PriceMaxPerUnit = 1111, PriceMinPerUnit = 1111, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 504, Product = product15, Unit = unit3, PriceAvgPerUnit = 722, PriceMaxPerUnit = 825, PriceMinPerUnit = 667, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 505, Product = product15, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 833, PriceMinPerUnit = 833, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 506, Product = product15, Unit = unit3, PriceAvgPerUnit = 308, PriceMaxPerUnit = 338, PriceMinPerUnit = 277, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 507, Product = product15, Unit = unit3, PriceAvgPerUnit = 290, PriceMaxPerUnit = 292, PriceMinPerUnit = 283, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 508, Product = product3, Unit = unit3, PriceAvgPerUnit = 2579, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 509, Product = product3, Unit = unit3, PriceAvgPerUnit = 1273, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 510, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 511, Product = product3, Unit = unit3, PriceAvgPerUnit = 1050, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 512, Product = product3, Unit = unit3, PriceAvgPerUnit = 3067, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 513, Product = product3, Unit = unit3, PriceAvgPerUnit = 4222, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 514, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 515, Product = product3, Unit = unit3, PriceAvgPerUnit = 3089, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 516, Product = product3, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 517, Product = product3, Unit = unit3, PriceAvgPerUnit = 715, PriceMaxPerUnit = 833, PriceMinPerUnit = 583, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 518, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 519, Product = product3, Unit = unit3, PriceAvgPerUnit = 1600, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1600, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 520, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 521, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 522, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 523, Product = product3, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1167, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 524, Product = product3, Unit = unit3, PriceAvgPerUnit = 674, PriceMaxPerUnit = 700, PriceMinPerUnit = 650, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 525, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 526, Product = product3, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 527, Product = product4, Unit = unit3, PriceAvgPerUnit = 3825, PriceMaxPerUnit = 4200, PriceMinPerUnit = 3500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 528, Product = product4, Unit = unit3, PriceAvgPerUnit = 2417, PriceMaxPerUnit = 3250, PriceMinPerUnit = 1250, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 529, Product = product4, Unit = unit3, PriceAvgPerUnit = 1875, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1750, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 530, Product = product4, Unit = unit3, PriceAvgPerUnit = 2167, PriceMaxPerUnit = 2333, PriceMinPerUnit = 2000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 531, Product = product4, Unit = unit3, PriceAvgPerUnit = 3700, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3200, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 532, Product = product4, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 533, Product = product4, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 534, Product = product4, Unit = unit3, PriceAvgPerUnit = 3000, PriceMaxPerUnit = 3000, PriceMinPerUnit = 3000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 535, Product = product4, Unit = unit3, PriceAvgPerUnit = 2556, PriceMaxPerUnit = 4000, PriceMinPerUnit = 1333, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 536, Product = product4, Unit = unit3, PriceAvgPerUnit = 4333, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 537, Product = product4, Unit = unit3, PriceAvgPerUnit = 4125, PriceMaxPerUnit = 4500, PriceMinPerUnit = 3500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 538, Product = product14, Unit = unit3, PriceAvgPerUnit = 499, PriceMaxPerUnit = 533, PriceMinPerUnit = 433, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 539, Product = product14, Unit = unit3, PriceAvgPerUnit = 517, PriceMaxPerUnit = 533, PriceMinPerUnit = 500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 540, Product = product14, Unit = unit3, PriceAvgPerUnit = 542, PriceMaxPerUnit = 567, PriceMinPerUnit = 533, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 541, Product = product15, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 857, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 542, Product = product15, Unit = unit3, PriceAvgPerUnit = 725, PriceMaxPerUnit = 750, PriceMinPerUnit = 700, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 543, Product = product15, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1222, PriceMinPerUnit = 1111, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 544, Product = product15, Unit = unit3, PriceAvgPerUnit = 625, PriceMaxPerUnit = 875, PriceMinPerUnit = 500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 545, Product = product15, Unit = unit3, PriceAvgPerUnit = 363, PriceMaxPerUnit = 385, PriceMinPerUnit = 308, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 546, Product = product15, Unit = unit3, PriceAvgPerUnit = 322, PriceMaxPerUnit = 333, PriceMinPerUnit = 292, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 547, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 548, Product = product3, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 549, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 550, Product = product3, Unit = unit3, PriceAvgPerUnit = 950, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 551, Product = product3, Unit = unit3, PriceAvgPerUnit = 2556, PriceMaxPerUnit = 3200, PriceMinPerUnit = 2000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 552, Product = product3, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 553, Product = product3, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 554, Product = product3, Unit = unit3, PriceAvgPerUnit = 2628, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2400, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 555, Product = product3, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 556, Product = product3, Unit = unit3, PriceAvgPerUnit = 583, PriceMaxPerUnit = 667, PriceMinPerUnit = 500, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 557, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 558, Product = product3, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 559, Product = product3, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 560, Product = product3, Unit = unit3, PriceAvgPerUnit = 1779, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 561, Product = product3, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 562, Product = product3, Unit = unit3, PriceAvgPerUnit = 880, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 563, Product = product3, Unit = unit3, PriceAvgPerUnit = 805, PriceMaxPerUnit = 950, PriceMinPerUnit = 680, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 564, Product = product3, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 565, Product = product4, Unit = unit3, PriceAvgPerUnit = 2538, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 566, Product = product4, Unit = unit3, PriceAvgPerUnit = 4392, PriceMaxPerUnit = 4700, PriceMinPerUnit = 3800, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 567, Product = product4, Unit = unit3, PriceAvgPerUnit = 1633, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1250, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 568, Product = product4, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2333, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 569, Product = product4, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 570, Product = product4, Unit = unit3, PriceAvgPerUnit = 3667, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3200, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 571, Product = product4, Unit = unit3, PriceAvgPerUnit = 2333, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 572, Product = product4, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 573, Product = product4, Unit = unit3, PriceAvgPerUnit = 3333, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 574, Product = product4, Unit = unit3, PriceAvgPerUnit = 2556, PriceMaxPerUnit = 4000, PriceMinPerUnit = 2000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 575, Product = product4, Unit = unit3, PriceAvgPerUnit = 3813, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 576, Product = product4, Unit = unit3, PriceAvgPerUnit = 3667, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 577, Product = product14, Unit = unit3, PriceAvgPerUnit = 514, PriceMaxPerUnit = 533, PriceMinPerUnit = 467, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 578, Product = product14, Unit = unit3, PriceAvgPerUnit = 558, PriceMaxPerUnit = 567, PriceMinPerUnit = 533, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 579, Product = product14, Unit = unit3, PriceAvgPerUnit = 417, PriceMaxPerUnit = 433, PriceMinPerUnit = 400, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 580, Product = product15, Unit = unit3, PriceAvgPerUnit = 714, PriceMaxPerUnit = 714, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 581, Product = product15, Unit = unit3, PriceAvgPerUnit = 688, PriceMaxPerUnit = 750, PriceMinPerUnit = 575, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 582, Product = product15, Unit = unit3, PriceAvgPerUnit = 1633, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1500, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 583, Product = product15, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 667, PriceMinPerUnit = 667, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 584, Product = product15, Unit = unit3, PriceAvgPerUnit = 344, PriceMaxPerUnit = 385, PriceMinPerUnit = 308, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 585, Product = product15, Unit = unit3, PriceAvgPerUnit = 288, PriceMaxPerUnit = 300, PriceMinPerUnit = 250, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 586, Product = product56, Unit = unit3, PriceAvgPerUnit = 789, PriceMaxPerUnit = 917, PriceMinPerUnit = 667, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 587, Product = product57, Unit = unit3, PriceAvgPerUnit = 835, PriceMaxPerUnit = 900, PriceMinPerUnit = 800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 588, Product = product57, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 589, Product = product57, Unit = unit3, PriceAvgPerUnit = 464, PriceMaxPerUnit = 480, PriceMinPerUnit = 448, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 590, Product = product57, Unit = unit3, PriceAvgPerUnit = 446, PriceMaxPerUnit = 462, PriceMinPerUnit = 431, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 591, Product = product57, Unit = unit3, PriceAvgPerUnit = 775, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 592, Product = product57, Unit = unit3, PriceAvgPerUnit = 600, PriceMaxPerUnit = 600, PriceMinPerUnit = 600, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 593, Product = product57, Unit = unit3, PriceAvgPerUnit = 556, PriceMaxPerUnit = 700, PriceMinPerUnit = 500, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 594, Product = product57, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 595, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 596, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 597, Product = product57, Unit = unit3, PriceAvgPerUnit = 733, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 598, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 599, Product = product57, Unit = unit3, PriceAvgPerUnit = 767, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 600, Product = product57, Unit = unit3, PriceAvgPerUnit = 650, PriceMaxPerUnit = 650, PriceMinPerUnit = 650, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 601, Product = product57, Unit = unit3, PriceAvgPerUnit = 1036, PriceMaxPerUnit = 1400, PriceMinPerUnit = 800, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 602, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 603, Product = product1, Unit = unit3, PriceAvgPerUnit = 400, PriceMaxPerUnit = 500, PriceMinPerUnit = 300, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 604, Product = product1, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 605, Product = product1, Unit = unit3, PriceAvgPerUnit = 980, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 606, Product = product1, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 607, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 608, Product = product1, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 609, Product = product1, Unit = unit3, PriceAvgPerUnit = 904, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 610, Product = product1, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 611, Product = product1, Unit = unit3, PriceAvgPerUnit = 892, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 612, Product = product1, Unit = unit3, PriceAvgPerUnit = 1700, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 613, Product = product1, Unit = unit3, PriceAvgPerUnit = 1548, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 614, Product = product1, Unit = unit3, PriceAvgPerUnit = 680, PriceMaxPerUnit = 800, PriceMinPerUnit = 640, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 615, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 616, Product = product1, Unit = unit3, PriceAvgPerUnit = 1046, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1000, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 617, Product = product1, Unit = unit3, PriceAvgPerUnit = 3233, PriceMaxPerUnit = 3400, PriceMinPerUnit = 3000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 618, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 619, Product = product2, Unit = unit3, PriceAvgPerUnit = 1213, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 620, Product = product2, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 621, Product = product2, Unit = unit3, PriceAvgPerUnit = 978, PriceMaxPerUnit = 1200, PriceMinPerUnit = 800, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 622, Product = product2, Unit = unit3, PriceAvgPerUnit = 900, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 623, Product = product2, Unit = unit3, PriceAvgPerUnit = 1367, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1200, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 624, Product = product2, Unit = unit3, PriceAvgPerUnit = 1875, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 625, Product = product2, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 626, Product = product2, Unit = unit3, PriceAvgPerUnit = 958, PriceMaxPerUnit = 1167, PriceMinPerUnit = 833, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 627, Product = product2, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1800, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 628, Product = product17, Unit = unit3, PriceAvgPerUnit = 566, PriceMaxPerUnit = 592, PriceMinPerUnit = 560, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 629, Product = product17, Unit = unit3, PriceAvgPerUnit = 750, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 630, Product = product17, Unit = unit3, PriceAvgPerUnit = 608, PriceMaxPerUnit = 633, PriceMinPerUnit = 583, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 631, Product = product17, Unit = unit3, PriceAvgPerUnit = 273, PriceMaxPerUnit = 300, PriceMinPerUnit = 240, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 632, Product = product17, Unit = unit3, PriceAvgPerUnit = 683, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 633, Product = product17, Unit = unit3, PriceAvgPerUnit = 487, PriceMaxPerUnit = 500, PriceMinPerUnit = 400, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 634, Product = product38, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 635, Product = product38, Unit = unit3, PriceAvgPerUnit = 1593, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1400, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 636, Product = product38, Unit = unit3, PriceAvgPerUnit = 1755, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 637, Product = product38, Unit = unit3, PriceAvgPerUnit = 1375, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 638, Product = product38, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 639, Product = product38, Unit = unit3, PriceAvgPerUnit = 2020, PriceMaxPerUnit = 2400, PriceMinPerUnit = 1600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 640, Product = product39, Unit = unit3, PriceAvgPerUnit = 2322, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 641, Product = product39, Unit = unit3, PriceAvgPerUnit = 2450, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2400, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 642, Product = product40, Unit = unit3, PriceAvgPerUnit = 1640, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1600, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 643, Product = product40, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 644, Product = product40, Unit = unit3, PriceAvgPerUnit = 1820, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1660, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 645, Product = product40, Unit = unit3, PriceAvgPerUnit = 1480, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 646, Product = product40, Unit = unit3, PriceAvgPerUnit = 1538, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 647, Product = product40, Unit = unit3, PriceAvgPerUnit = 1875, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 648, Product = product40, Unit = unit3, PriceAvgPerUnit = 1760, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 649, Product = product40, Unit = unit3, PriceAvgPerUnit = 1558, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 650, Product = product40, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 651, Product = product40, Unit = unit3, PriceAvgPerUnit = 1678, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 652, Product = product40, Unit = unit3, PriceAvgPerUnit = 1402, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Peñol (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 653, Product = product40, Unit = unit3, PriceAvgPerUnit = 1575, PriceMaxPerUnit = 1900, PriceMinPerUnit = 1350, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 654, Product = product40, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1450, PriceMinPerUnit = 1350, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 655, Product = product40, Unit = unit3, PriceAvgPerUnit = 1288, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1250, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 656, Product = product55, Unit = unit3, PriceAvgPerUnit = 1344, PriceMaxPerUnit = 1367, PriceMinPerUnit = 1333, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 657, Product = product55, Unit = unit3, PriceAvgPerUnit = 1042, PriceMaxPerUnit = 1083, PriceMinPerUnit = 1000, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 658, Product = product55, Unit = unit3, PriceAvgPerUnit = 1958, PriceMaxPerUnit = 2083, PriceMinPerUnit = 1833, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 659, Product = product56, Unit = unit3, PriceAvgPerUnit = 797, PriceMaxPerUnit = 882, PriceMinPerUnit = 706, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 660, Product = product56, Unit = unit3, PriceAvgPerUnit = 712, PriceMaxPerUnit = 824, PriceMinPerUnit = 556, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 661, Product = product56, Unit = unit3, PriceAvgPerUnit = 893, PriceMaxPerUnit = 945, PriceMinPerUnit = 842, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 662, Product = product56, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 663, Product = product56, Unit = unit3, PriceAvgPerUnit = 770, PriceMaxPerUnit = 833, PriceMinPerUnit = 720, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 664, Product = product17, Unit = unit3, PriceAvgPerUnit = 793, PriceMaxPerUnit = 857, PriceMinPerUnit = 714, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 665, Product = product17, Unit = unit3, PriceAvgPerUnit = 480, PriceMaxPerUnit = 480, PriceMinPerUnit = 480, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 666, Product = product17, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 667, PriceMinPerUnit = 667, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 667, Product = product17, Unit = unit3, PriceAvgPerUnit = 1030, PriceMaxPerUnit = 1200, PriceMinPerUnit = 920, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 668, Product = product17, Unit = unit3, PriceAvgPerUnit = 575, PriceMaxPerUnit = 640, PriceMinPerUnit = 500, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 669, Product = product17, Unit = unit3, PriceAvgPerUnit = 683, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 670, Product = product17, Unit = unit3, PriceAvgPerUnit = 757, PriceMaxPerUnit = 800, PriceMinPerUnit = 720, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 671, Product = product38, Unit = unit3, PriceAvgPerUnit = 1168, PriceMaxPerUnit = 1360, PriceMinPerUnit = 960, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 672, Product = product38, Unit = unit3, PriceAvgPerUnit = 1225, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1100, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 673, Product = product38, Unit = unit3, PriceAvgPerUnit = 1667, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1400, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 674, Product = product38, Unit = unit3, PriceAvgPerUnit = 1600, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1600, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 675, Product = product38, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 1920, PriceMinPerUnit = 1680, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 676, Product = product38, Unit = unit3, PriceAvgPerUnit = 2160, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 677, Product = product39, Unit = unit3, PriceAvgPerUnit = 2025, PriceMaxPerUnit = 2083, PriceMinPerUnit = 1900, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 678, Product = product40, Unit = unit3, PriceAvgPerUnit = 2092, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1900, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 679, Product = product40, Unit = unit3, PriceAvgPerUnit = 1873, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 680, Product = product40, Unit = unit3, PriceAvgPerUnit = 1525, PriceMaxPerUnit = 1560, PriceMinPerUnit = 1500, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 681, Product = product40, Unit = unit3, PriceAvgPerUnit = 2142, PriceMaxPerUnit = 2600, PriceMinPerUnit = 1800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 682, Product = product40, Unit = unit3, PriceAvgPerUnit = 2163, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2100, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 683, Product = product40, Unit = unit3, PriceAvgPerUnit = 1425, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 684, Product = product40, Unit = unit3, PriceAvgPerUnit = 1680, PriceMaxPerUnit = 1760, PriceMinPerUnit = 1600, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 685, Product = product40, Unit = unit3, PriceAvgPerUnit = 1563, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1400, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 686, Product = product40, Unit = unit3, PriceAvgPerUnit = 1150, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 687, Product = product40, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 688, Product = product40, Unit = unit3, PriceAvgPerUnit = 1472, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1300, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 689, Product = product40, Unit = unit3, PriceAvgPerUnit = 1450, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1300, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 690, Product = product40, Unit = unit3, PriceAvgPerUnit = 1350, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 691, Product = product40, Unit = unit3, PriceAvgPerUnit = 1483, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 692, Product = product55, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Buenaventura (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 693, Product = product55, Unit = unit3, PriceAvgPerUnit = 1528, PriceMaxPerUnit = 1583, PriceMinPerUnit = 1500, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 694, Product = product55, Unit = unit3, PriceAvgPerUnit = 1843, PriceMaxPerUnit = 1917, PriceMinPerUnit = 1750, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 695, Product = product56, Unit = unit3, PriceAvgPerUnit = 1161, PriceMaxPerUnit = 1294, PriceMinPerUnit = 1059, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 696, Product = product56, Unit = unit3, PriceAvgPerUnit = 575, PriceMaxPerUnit = 824, PriceMinPerUnit = 471, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 697, Product = product56, Unit = unit3, PriceAvgPerUnit = 763, PriceMaxPerUnit = 941, PriceMinPerUnit = 647, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 698, Product = product56, Unit = unit3, PriceAvgPerUnit = 1256, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 699, Product = product56, Unit = unit3, PriceAvgPerUnit = 542, PriceMaxPerUnit = 633, PriceMinPerUnit = 467, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 700, Product = product56, Unit = unit3, PriceAvgPerUnit = 769, PriceMaxPerUnit = 889, PriceMinPerUnit = 611, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 701, Product = product57, Unit = unit3, PriceAvgPerUnit = 858, PriceMaxPerUnit = 900, PriceMinPerUnit = 800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 702, Product = product57, Unit = unit3, PriceAvgPerUnit = 1256, PriceMaxPerUnit = 1314, PriceMinPerUnit = 1200, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 703, Product = product57, Unit = unit3, PriceAvgPerUnit = 496, PriceMaxPerUnit = 512, PriceMinPerUnit = 480, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 704, Product = product57, Unit = unit3, PriceAvgPerUnit = 462, PriceMaxPerUnit = 462, PriceMinPerUnit = 462, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 705, Product = product57, Unit = unit3, PriceAvgPerUnit = 775, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 706, Product = product57, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1100, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 707, Product = product57, Unit = unit3, PriceAvgPerUnit = 600, PriceMaxPerUnit = 600, PriceMinPerUnit = 600, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 708, Product = product57, Unit = unit3, PriceAvgPerUnit = 979, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 709, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 710, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 711, Product = product57, Unit = unit3, PriceAvgPerUnit = 678, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 712, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 713, Product = product57, Unit = unit3, PriceAvgPerUnit = 820, PriceMaxPerUnit = 900, PriceMinPerUnit = 800, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 714, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 715, Product = product57, Unit = unit3, PriceAvgPerUnit = 1356, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 716, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 717, Product = product1, Unit = unit3, PriceAvgPerUnit = 378, PriceMaxPerUnit = 600, PriceMinPerUnit = 300, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 718, Product = product1, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 719, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1333, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 720, Product = product1, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 721, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 722, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 723, Product = product1, Unit = unit3, PriceAvgPerUnit = 950, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 724, Product = product1, Unit = unit3, PriceAvgPerUnit = 1792, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 725, Product = product1, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 726, Product = product1, Unit = unit3, PriceAvgPerUnit = 1567, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1400, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 727, Product = product1, Unit = unit3, PriceAvgPerUnit = 1550, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1500, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 728, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 729, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 730, Product = product1, Unit = unit3, PriceAvgPerUnit = 1004, PriceMaxPerUnit = 1300, PriceMinPerUnit = 800, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 731, Product = product2, Unit = unit3, PriceAvgPerUnit = 548, PriceMaxPerUnit = 700, PriceMinPerUnit = 400, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 732, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 733, Product = product2, Unit = unit3, PriceAvgPerUnit = 1187, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 734, Product = product2, Unit = unit3, PriceAvgPerUnit = 1070, PriceMaxPerUnit = 1120, PriceMinPerUnit = 960, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 735, Product = product2, Unit = unit3, PriceAvgPerUnit = 948, PriceMaxPerUnit = 1067, PriceMinPerUnit = 800, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 736, Product = product2, Unit = unit3, PriceAvgPerUnit = 867, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 737, Product = product2, Unit = unit3, PriceAvgPerUnit = 892, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 738, Product = product2, Unit = unit3, PriceAvgPerUnit = 1958, PriceMaxPerUnit = 2500, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 739, Product = product2, Unit = unit3, PriceAvgPerUnit = 1208, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 740, Product = product2, Unit = unit3, PriceAvgPerUnit = 1028, PriceMaxPerUnit = 1250, PriceMinPerUnit = 833, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 741, Product = product2, Unit = unit3, PriceAvgPerUnit = 1983, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 742, Product = product56, Unit = unit3, PriceAvgPerUnit = 772, PriceMaxPerUnit = 824, PriceMinPerUnit = 676, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 743, Product = product57, Unit = unit3, PriceAvgPerUnit = 820, PriceMaxPerUnit = 850, PriceMinPerUnit = 800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 744, Product = product57, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 745, Product = product57, Unit = unit3, PriceAvgPerUnit = 592, PriceMaxPerUnit = 615, PriceMinPerUnit = 554, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 746, Product = product57, Unit = unit3, PriceAvgPerUnit = 462, PriceMaxPerUnit = 462, PriceMinPerUnit = 462, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 747, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 748, Product = product57, Unit = unit3, PriceAvgPerUnit = 405, PriceMaxPerUnit = 420, PriceMinPerUnit = 400, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 749, Product = product57, Unit = unit3, PriceAvgPerUnit = 1350, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1300, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 750, Product = product57, Unit = unit3, PriceAvgPerUnit = 613, PriceMaxPerUnit = 640, PriceMinPerUnit = 560, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 751, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 752, Product = product57, Unit = unit3, PriceAvgPerUnit = 763, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 753, Product = product57, Unit = unit3, PriceAvgPerUnit = 500, PriceMaxPerUnit = 500, PriceMinPerUnit = 500, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 754, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 755, Product = product57, Unit = unit3, PriceAvgPerUnit = 622, PriceMaxPerUnit = 650, PriceMinPerUnit = 600, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 756, Product = product57, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 757, Product = product57, Unit = unit3, PriceAvgPerUnit = 604, PriceMaxPerUnit = 700, PriceMinPerUnit = 440, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 758, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 759, Product = product1, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 760, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 761, Product = product1, Unit = unit3, PriceAvgPerUnit = 1333, PriceMaxPerUnit = 1333, PriceMinPerUnit = 1333, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 762, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 763, Product = product1, Unit = unit3, PriceAvgPerUnit = 750, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 764, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 765, Product = product1, Unit = unit3, PriceAvgPerUnit = 1875, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 766, Product = product1, Unit = unit3, PriceAvgPerUnit = 831, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 767, Product = product1, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 768, Product = product1, Unit = unit3, PriceAvgPerUnit = 1625, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 769, Product = product1, Unit = unit3, PriceAvgPerUnit = 740, PriceMaxPerUnit = 800, PriceMinPerUnit = 640, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 770, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 771, Product = product1, Unit = unit3, PriceAvgPerUnit = 1026, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 772, Product = product1, Unit = unit3, PriceAvgPerUnit = 3375, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3200, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 773, Product = product2, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 774, Product = product2, Unit = unit3, PriceAvgPerUnit = 1420, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1300, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 775, Product = product2, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 776, Product = product2, Unit = unit3, PriceAvgPerUnit = 1210, PriceMaxPerUnit = 1360, PriceMinPerUnit = 1120, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 777, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 778, Product = product2, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 779, Product = product2, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 780, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 781, Product = product2, Unit = unit3, PriceAvgPerUnit = 979, PriceMaxPerUnit = 1250, PriceMinPerUnit = 833, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 782, Product = product2, Unit = unit3, PriceAvgPerUnit = 1083, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 783, Product = product2, Unit = unit3, PriceAvgPerUnit = 1153, PriceMaxPerUnit = 1250, PriceMinPerUnit = 833, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 784, Product = product2, Unit = unit3, PriceAvgPerUnit = 1083, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1000, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 785, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 786, Product = product2, Unit = unit3, PriceAvgPerUnit = 733, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 787, Product = product2, Unit = unit3, PriceAvgPerUnit = 880, PriceMaxPerUnit = 960, PriceMinPerUnit = 800, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 788, Product = product2, Unit = unit3, PriceAvgPerUnit = 642, PriceMaxPerUnit = 706, PriceMinPerUnit = 588, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 789, Product = product2, Unit = unit3, PriceAvgPerUnit = 1031, PriceMaxPerUnit = 1200, PriceMinPerUnit = 960, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 790, Product = product9, Unit = unit3, PriceAvgPerUnit = 2851, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2667, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 791, Product = product10, Unit = unit3, PriceAvgPerUnit = 2494, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 792, Product = product10, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 793, Product = product10, Unit = unit3, PriceAvgPerUnit = 2200, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 794, Product = product11, Unit = unit3, PriceAvgPerUnit = 1969, PriceMaxPerUnit = 2333, PriceMinPerUnit = 1667, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 795, Product = product11, Unit = unit3, PriceAvgPerUnit = 2700, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2333, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 796, Product = product11, Unit = unit3, PriceAvgPerUnit = 3000, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 797, Product = product11, Unit = unit3, PriceAvgPerUnit = 3833, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3667, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 798, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 799, Product = product11, Unit = unit3, PriceAvgPerUnit = 8667, PriceMaxPerUnit = 10000, PriceMinPerUnit = 8000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 800, Product = product11, Unit = unit3, PriceAvgPerUnit = 2167, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 801, Product = product11, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 802, Product = product11, Unit = unit3, PriceAvgPerUnit = 3000, PriceMaxPerUnit = 3000, PriceMinPerUnit = 3000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 803, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 804, Product = product11, Unit = unit3, PriceAvgPerUnit = 3188, PriceMaxPerUnit = 3750, PriceMinPerUnit = 3000, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 805, Product = product11, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1000, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 806, Product = product12, Unit = unit3, PriceAvgPerUnit = 1072, PriceMaxPerUnit = 1143, PriceMinPerUnit = 1000, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 807, Product = product12, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 808, Product = product12, Unit = unit3, PriceAvgPerUnit = 1104, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1083, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 809, Product = product12, Unit = unit3, PriceAvgPerUnit = 690, PriceMaxPerUnit = 714, PriceMinPerUnit = 643, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 810, Product = product12, Unit = unit3, PriceAvgPerUnit = 417, PriceMaxPerUnit = 417, PriceMinPerUnit = 417, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 811, Product = product12, Unit = unit3, PriceAvgPerUnit = 711, PriceMaxPerUnit = 733, PriceMinPerUnit = 693, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 812, Product = product12, Unit = unit3, PriceAvgPerUnit = 197, PriceMaxPerUnit = 233, PriceMinPerUnit = 150, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 813, Product = product36, Unit = unit3, PriceAvgPerUnit = 2198, PriceMaxPerUnit = 2300, PriceMinPerUnit = 2000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 814, Product = product36, Unit = unit3, PriceAvgPerUnit = 1953, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1700, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 815, Product = product36, Unit = unit3, PriceAvgPerUnit = 1950, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 816, Product = product36, Unit = unit3, PriceAvgPerUnit = 1950, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 817, Product = product36, Unit = unit3, PriceAvgPerUnit = 2625, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 818, Product = product36, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 819, Product = product36, Unit = unit3, PriceAvgPerUnit = 1987, PriceMaxPerUnit = 2080, PriceMinPerUnit = 1840, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 820, Product = product36, Unit = unit3, PriceAvgPerUnit = 2433, PriceMaxPerUnit = 2600, PriceMinPerUnit = 2200, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 821, Product = product36, Unit = unit3, PriceAvgPerUnit = 2272, PriceMaxPerUnit = 2600, PriceMinPerUnit = 2000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 822, Product = product36, Unit = unit3, PriceAvgPerUnit = 2227, PriceMaxPerUnit = 2917, PriceMinPerUnit = 2000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 823, Product = product36, Unit = unit3, PriceAvgPerUnit = 1787, PriceMaxPerUnit = 1920, PriceMinPerUnit = 1760, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 824, Product = product36, Unit = unit3, PriceAvgPerUnit = 1760, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 825, Product = product36, Unit = unit3, PriceAvgPerUnit = 1967, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 826, Product = product36, Unit = unit3, PriceAvgPerUnit = 2720, PriceMaxPerUnit = 2800, PriceMinPerUnit = 2640, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 827, Product = product36, Unit = unit3, PriceAvgPerUnit = 1669, PriceMaxPerUnit = 1840, PriceMinPerUnit = 1600, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 828, Product = product36, Unit = unit3, PriceAvgPerUnit = 2044, PriceMaxPerUnit = 2240, PriceMinPerUnit = 2000, Location = "Cartago (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 829, Product = product36, Unit = unit3, PriceAvgPerUnit = 1770, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1720, Location = "Palmira (Valle del Cauca)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 830, Product = product36, Unit = unit3, PriceAvgPerUnit = 1733, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 831, Product = product36, Unit = unit3, PriceAvgPerUnit = 2525, PriceMaxPerUnit = 2600, PriceMinPerUnit = 2400, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 832, Product = product36, Unit = unit3, PriceAvgPerUnit = 2378, PriceMaxPerUnit = 2700, PriceMinPerUnit = 2000, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 833, Product = product36, Unit = unit3, PriceAvgPerUnit = 1730, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1650, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 834, Product = product36, Unit = unit3, PriceAvgPerUnit = 1950, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1900, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 835, Product = product36, Unit = unit3, PriceAvgPerUnit = 1933, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 836, Product = product36, Unit = unit3, PriceAvgPerUnit = 4833, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4500, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 837, Product = product36, Unit = unit3, PriceAvgPerUnit = 4750, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4500, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 838, Product = product43, Unit = unit3, PriceAvgPerUnit = 3167, PriceMaxPerUnit = 3500, PriceMinPerUnit = 2850, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 839, Product = product55, Unit = unit3, PriceAvgPerUnit = 1833, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1667, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 840, Product = product55, Unit = unit3, PriceAvgPerUnit = 1951, PriceMaxPerUnit = 2167, PriceMinPerUnit = 1500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 841, Product = product55, Unit = unit3, PriceAvgPerUnit = 1785, PriceMaxPerUnit = 1833, PriceMinPerUnit = 1700, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 842, Product = product55, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 843, Product = product55, Unit = unit3, PriceAvgPerUnit = 1538, PriceMaxPerUnit = 1583, PriceMinPerUnit = 1500, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 844, Product = product68, Unit = unit3, PriceAvgPerUnit = 1020, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1000, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 845, Product = product68, Unit = unit3, PriceAvgPerUnit = 933, PriceMaxPerUnit = 1000, PriceMinPerUnit = 867, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 846, Product = product68, Unit = unit3, PriceAvgPerUnit = 867, PriceMaxPerUnit = 933, PriceMinPerUnit = 800, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 847, Product = product68, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 848, Product = product68, Unit = unit3, PriceAvgPerUnit = 1547, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 849, Product = product68, Unit = unit3, PriceAvgPerUnit = 1454, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1200, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 850, Product = product68, Unit = unit3, PriceAvgPerUnit = 1117, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1100, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 851, Product = product7, Unit = unit3, PriceAvgPerUnit = 971, PriceMaxPerUnit = 1000, PriceMinPerUnit = 600, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 852, Product = product7, Unit = unit3, PriceAvgPerUnit = 597, PriceMaxPerUnit = 700, PriceMinPerUnit = 500, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 853, Product = product7, Unit = unit3, PriceAvgPerUnit = 4250, PriceMaxPerUnit = 4500, PriceMinPerUnit = 4000, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 854, Product = product8, Unit = unit3, PriceAvgPerUnit = 1001, PriceMaxPerUnit = 1200, PriceMinPerUnit = 800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 855, Product = product8, Unit = unit3, PriceAvgPerUnit = 989, PriceMaxPerUnit = 1067, PriceMinPerUnit = 933, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 856, Product = product8, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 857, Product = product8, Unit = unit3, PriceAvgPerUnit = 1050, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1000, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 858, Product = product8, Unit = unit3, PriceAvgPerUnit = 1100, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 859, Product = product8, Unit = unit3, PriceAvgPerUnit = 833, PriceMaxPerUnit = 833, PriceMinPerUnit = 833, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 860, Product = product8, Unit = unit3, PriceAvgPerUnit = 972, PriceMaxPerUnit = 1000, PriceMinPerUnit = 833, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 861, Product = product8, Unit = unit3, PriceAvgPerUnit = 1300, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 862, Product = product8, Unit = unit3, PriceAvgPerUnit = 1320, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1120, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 863, Product = product8, Unit = unit3, PriceAvgPerUnit = 1208, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1200, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 864, Product = product2, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1083, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 865, Product = product2, Unit = unit3, PriceAvgPerUnit = 1237, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1083, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 866, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1120, PriceMinPerUnit = 960, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 867, Product = product2, Unit = unit3, PriceAvgPerUnit = 760, PriceMaxPerUnit = 824, PriceMinPerUnit = 647, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 868, Product = product2, Unit = unit3, PriceAvgPerUnit = 706, PriceMaxPerUnit = 765, PriceMinPerUnit = 647, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 869, Product = product9, Unit = unit3, PriceAvgPerUnit = 2667, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2667, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 870, Product = product9, Unit = unit3, PriceAvgPerUnit = 1625, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1500, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 871, Product = product10, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 872, Product = product10, Unit = unit3, PriceAvgPerUnit = 4833, PriceMaxPerUnit = 5600, PriceMinPerUnit = 4800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 873, Product = product10, Unit = unit3, PriceAvgPerUnit = 725, PriceMaxPerUnit = 800, PriceMinPerUnit = 600, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 874, Product = product11, Unit = unit3, PriceAvgPerUnit = 1692, PriceMaxPerUnit = 2667, PriceMinPerUnit = 1333, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 875, Product = product11, Unit = unit3, PriceAvgPerUnit = 2833, PriceMaxPerUnit = 3333, PriceMinPerUnit = 2667, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 876, Product = product11, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2667, PriceMinPerUnit = 2333, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 877, Product = product11, Unit = unit3, PriceAvgPerUnit = 3500, PriceMaxPerUnit = 3667, PriceMinPerUnit = 3333, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 878, Product = product11, Unit = unit3, PriceAvgPerUnit = 8000, PriceMaxPerUnit = 8000, PriceMinPerUnit = 8000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 879, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 880, Product = product11, Unit = unit3, PriceAvgPerUnit = 3208, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3000, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 881, Product = product11, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 882, Product = product11, Unit = unit3, PriceAvgPerUnit = 4333, PriceMaxPerUnit = 5000, PriceMinPerUnit = 4000, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 883, Product = product11, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 884, Product = product11, Unit = unit3, PriceAvgPerUnit = 1925, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1800, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 885, Product = product11, Unit = unit3, PriceAvgPerUnit = 3750, PriceMaxPerUnit = 4000, PriceMinPerUnit = 3500, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 886, Product = product12, Unit = unit3, PriceAvgPerUnit = 876, PriceMaxPerUnit = 929, PriceMinPerUnit = 857, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 887, Product = product12, Unit = unit3, PriceAvgPerUnit = 1167, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1167, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 888, Product = product12, Unit = unit3, PriceAvgPerUnit = 265, PriceMaxPerUnit = 280, PriceMinPerUnit = 260, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 889, Product = product12, Unit = unit3, PriceAvgPerUnit = 548, PriceMaxPerUnit = 571, PriceMinPerUnit = 500, Location = "Valledupar, Mercabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 890, Product = product12, Unit = unit3, PriceAvgPerUnit = 791, PriceMaxPerUnit = 867, PriceMinPerUnit = 693, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 891, Product = product12, Unit = unit3, PriceAvgPerUnit = 1135, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 892, Product = product12, Unit = unit3, PriceAvgPerUnit = 331, PriceMaxPerUnit = 367, PriceMinPerUnit = 283, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 893, Product = product36, Unit = unit3, PriceAvgPerUnit = 1953, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1800, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 894, Product = product36, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 895, Product = product36, Unit = unit3, PriceAvgPerUnit = 2200, PriceMaxPerUnit = 2200, PriceMinPerUnit = 2200, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 896, Product = product36, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 897, Product = product36, Unit = unit3, PriceAvgPerUnit = 4000, PriceMaxPerUnit = 4000, PriceMinPerUnit = 4000, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 898, Product = product36, Unit = unit3, PriceAvgPerUnit = 1750, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 899, Product = product36, Unit = unit3, PriceAvgPerUnit = 2100, PriceMaxPerUnit = 2400, PriceMinPerUnit = 1800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 900, Product = product36, Unit = unit3, PriceAvgPerUnit = 1589, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1400, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 901, Product = product36, Unit = unit3, PriceAvgPerUnit = 3132, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3000, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 902, Product = product36, Unit = unit3, PriceAvgPerUnit = 1520, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 903, Product = product17, Unit = unit3, PriceAvgPerUnit = 494, PriceMaxPerUnit = 560, PriceMinPerUnit = 480, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 904, Product = product17, Unit = unit3, PriceAvgPerUnit = 792, PriceMaxPerUnit = 833, PriceMinPerUnit = 750, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 905, Product = product17, Unit = unit3, PriceAvgPerUnit = 750, PriceMaxPerUnit = 800, PriceMinPerUnit = 640, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 906, Product = product17, Unit = unit3, PriceAvgPerUnit = 600, PriceMaxPerUnit = 600, PriceMinPerUnit = 600, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 907, Product = product17, Unit = unit3, PriceAvgPerUnit = 453, PriceMaxPerUnit = 500, PriceMinPerUnit = 400, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 908, Product = product17, Unit = unit3, PriceAvgPerUnit = 853, PriceMaxPerUnit = 960, PriceMinPerUnit = 768, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 909, Product = product38, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 910, Product = product38, Unit = unit3, PriceAvgPerUnit = 1208, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1100, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 911, Product = product38, Unit = unit3, PriceAvgPerUnit = 1729, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1400, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 912, Product = product38, Unit = unit3, PriceAvgPerUnit = 2000, PriceMaxPerUnit = 2000, PriceMinPerUnit = 2000, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 913, Product = product38, Unit = unit3, PriceAvgPerUnit = 1520, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 914, Product = product38, Unit = unit3, PriceAvgPerUnit = 2133, PriceMaxPerUnit = 2600, PriceMinPerUnit = 1600, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 915, Product = product39, Unit = unit3, PriceAvgPerUnit = 2671, PriceMaxPerUnit = 3000, PriceMinPerUnit = 2500, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 916, Product = product40, Unit = unit3, PriceAvgPerUnit = 1768, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 917, Product = product40, Unit = unit3, PriceAvgPerUnit = 1777, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1700, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 918, Product = product40, Unit = unit3, PriceAvgPerUnit = 1310, PriceMaxPerUnit = 1340, PriceMinPerUnit = 1280, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 919, Product = product40, Unit = unit3, PriceAvgPerUnit = 1913, PriceMaxPerUnit = 2200, PriceMinPerUnit = 1700, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 920, Product = product40, Unit = unit3, PriceAvgPerUnit = 2230, PriceMaxPerUnit = 2400, PriceMinPerUnit = 2100, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 921, Product = product40, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1400, Location = "Cali, Santa Helena", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 922, Product = product40, Unit = unit3, PriceAvgPerUnit = 1540, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1440, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 923, Product = product40, Unit = unit3, PriceAvgPerUnit = 1608, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1300, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 924, Product = product40, Unit = unit3, PriceAvgPerUnit = 1990, PriceMaxPerUnit = 2300, PriceMinPerUnit = 1700, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 925, Product = product40, Unit = unit3, PriceAvgPerUnit = 1478, PriceMaxPerUnit = 1600, PriceMinPerUnit = 1300, Location = "La Ceja (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 926, Product = product40, Unit = unit3, PriceAvgPerUnit = 1463, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1250, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 927, Product = product40, Unit = unit3, PriceAvgPerUnit = 1454, PriceMaxPerUnit = 1700, PriceMinPerUnit = 1300, Location = "Peñol (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 928, Product = product40, Unit = unit3, PriceAvgPerUnit = 1250, PriceMaxPerUnit = 1300, PriceMinPerUnit = 1200, Location = "San Vicente (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 929, Product = product40, Unit = unit3, PriceAvgPerUnit = 1642, PriceMaxPerUnit = 1800, PriceMinPerUnit = 1500, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 930, Product = product40, Unit = unit3, PriceAvgPerUnit = 1395, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1380, Location = "Sonsón (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 931, Product = product55, Unit = unit3, PriceAvgPerUnit = 1458, PriceMaxPerUnit = 1750, PriceMinPerUnit = 1167, Location = "Tuluá (Valle del Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 932, Product = product55, Unit = unit3, PriceAvgPerUnit = 1646, PriceMaxPerUnit = 1917, PriceMinPerUnit = 1433, Location = "Barranquilla, Granabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 933, Product = product55, Unit = unit3, PriceAvgPerUnit = 1508, PriceMaxPerUnit = 1833, PriceMinPerUnit = 1133, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 934, Product = product56, Unit = unit3, PriceAvgPerUnit = 880, PriceMaxPerUnit = 1000, PriceMinPerUnit = 778, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 935, Product = product56, Unit = unit3, PriceAvgPerUnit = 765, PriceMaxPerUnit = 824, PriceMinPerUnit = 706, Location = "Medellín, Coomerca", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 936, Product = product56, Unit = unit3, PriceAvgPerUnit = 630, PriceMaxPerUnit = 665, PriceMinPerUnit = 579, Location = "Carmen de Viboral, (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 937, Product = product56, Unit = unit3, PriceAvgPerUnit = 954, PriceMaxPerUnit = 1100, PriceMinPerUnit = 853, Location = "Marinilla (Antioquia)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 938, Product = product56, Unit = unit3, PriceAvgPerUnit = 649, PriceMaxPerUnit = 765, PriceMinPerUnit = 529, Location = "Rionegro (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 939, Product = product56, Unit = unit3, PriceAvgPerUnit = 602, PriceMaxPerUnit = 722, PriceMinPerUnit = 500, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 940, Product = product57, Unit = unit3, PriceAvgPerUnit = 894, PriceMaxPerUnit = 1200, PriceMinPerUnit = 771, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 941, Product = product57, Unit = unit3, PriceAvgPerUnit = 546, PriceMaxPerUnit = 615, PriceMinPerUnit = 431, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 942, Product = product57, Unit = unit3, PriceAvgPerUnit = 408, PriceMaxPerUnit = 416, PriceMinPerUnit = 400, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 943, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 944, Product = product57, Unit = unit3, PriceAvgPerUnit = 445, PriceMaxPerUnit = 500, PriceMinPerUnit = 380, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 945, Product = product57, Unit = unit3, PriceAvgPerUnit = 1400, PriceMaxPerUnit = 1400, PriceMinPerUnit = 1400, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 946, Product = product57, Unit = unit3, PriceAvgPerUnit = 560, PriceMaxPerUnit = 560, PriceMinPerUnit = 560, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 947, Product = product57, Unit = unit3, PriceAvgPerUnit = 996, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 948, Product = product57, Unit = unit3, PriceAvgPerUnit = 763, PriceMaxPerUnit = 800, PriceMinPerUnit = 700, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 949, Product = product57, Unit = unit3, PriceAvgPerUnit = 500, PriceMaxPerUnit = 500, PriceMinPerUnit = 500, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 950, Product = product57, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 700, PriceMinPerUnit = 600, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 951, Product = product57, Unit = unit3, PriceAvgPerUnit = 660, PriceMaxPerUnit = 700, PriceMinPerUnit = 650, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 952, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 953, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 954, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 955, Product = product1, Unit = unit3, PriceAvgPerUnit = 2500, PriceMaxPerUnit = 2500, PriceMinPerUnit = 2500, Location = "Cartagena, Bazurto", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 956, Product = product1, Unit = unit3, PriceAvgPerUnit = 990, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 957, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1333, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 958, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 959, Product = product1, Unit = unit3, PriceAvgPerUnit = 400, PriceMaxPerUnit = 400, PriceMinPerUnit = 400, Location = "Ubaté (Cundinamarca)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 960, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1500, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 961, Product = product1, Unit = unit3, PriceAvgPerUnit = 1792, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1500, Location = "Pasto (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 962, Product = product1, Unit = unit3, PriceAvgPerUnit = 883, PriceMaxPerUnit = 1000, PriceMinPerUnit = 700, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 963, Product = product1, Unit = unit3, PriceAvgPerUnit = 1800, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 964, Product = product1, Unit = unit3, PriceAvgPerUnit = 1788, PriceMaxPerUnit = 2000, PriceMinPerUnit = 1600, Location = "Bucaramanga, Centroabastos", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 965, Product = product1, Unit = unit3, PriceAvgPerUnit = 680, PriceMaxPerUnit = 720, PriceMinPerUnit = 640, Location = "Ibagué, Plaza la 21", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 966, Product = product1, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Cali, Cavasa", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 967, Product = product1, Unit = unit3, PriceAvgPerUnit = 1041, PriceMaxPerUnit = 1300, PriceMinPerUnit = 900, Location = "Medellín, Central Mayorista de Antioquia", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 968, Product = product1, Unit = unit3, PriceAvgPerUnit = 3375, PriceMaxPerUnit = 3500, PriceMinPerUnit = 3200, Location = "Barranquilla, Barranquillita", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 969, Product = product2, Unit = unit3, PriceAvgPerUnit = 677, PriceMaxPerUnit = 1000, PriceMinPerUnit = 500, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 970, Product = product2, Unit = unit3, PriceAvgPerUnit = 1010, PriceMaxPerUnit = 1100, PriceMinPerUnit = 1000, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 971, Product = product2, Unit = unit3, PriceAvgPerUnit = 1200, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1200, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 972, Product = product2, Unit = unit3, PriceAvgPerUnit = 1170, PriceMaxPerUnit = 1200, PriceMinPerUnit = 1120, Location = "Manizales (Caldas)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 973, Product = product2, Unit = unit3, PriceAvgPerUnit = 933, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Montería (Córdoba)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 974, Product = product2, Unit = unit3, PriceAvgPerUnit = 1433, PriceMaxPerUnit = 1500, PriceMinPerUnit = 1400, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 975, Product = product2, Unit = unit3, PriceAvgPerUnit = 992, PriceMaxPerUnit = 1000, PriceMinPerUnit = 800, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 976, Product = product2, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Ipiales (Nariño)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 977, Product = product2, Unit = unit3, PriceAvgPerUnit = 889, PriceMaxPerUnit = 1000, PriceMinPerUnit = 833, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 978, Product = product2, Unit = unit3, PriceAvgPerUnit = 1083, PriceMaxPerUnit = 1167, PriceMinPerUnit = 1000, Location = "Pamplona (Norte de Santander)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 979, Product = product2, Unit = unit3, PriceAvgPerUnit = 917, PriceMaxPerUnit = 1167, PriceMinPerUnit = 833, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 980, Product = product2, Unit = unit3, PriceAvgPerUnit = 1125, PriceMaxPerUnit = 1250, PriceMinPerUnit = 1000, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 981, Product = product56, Unit = unit3, PriceAvgPerUnit = 655, PriceMaxPerUnit = 750, PriceMinPerUnit = 556, Location = "El Santuario (Antioquia)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 982, Product = product57, Unit = unit3, PriceAvgPerUnit = 855, PriceMaxPerUnit = 900, PriceMinPerUnit = 800, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 983, Product = product57, Unit = unit3, PriceAvgPerUnit = 449, PriceMaxPerUnit = 462, PriceMinPerUnit = 431, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 984, Product = product57, Unit = unit3, PriceAvgPerUnit = 480, PriceMaxPerUnit = 480, PriceMinPerUnit = 480, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 985, Product = product57, Unit = unit3, PriceAvgPerUnit = 446, PriceMaxPerUnit = 462, PriceMinPerUnit = 431, Location = "Sogamoso (Boyacá)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 986, Product = product57, Unit = unit3, PriceAvgPerUnit = 445, PriceMaxPerUnit = 460, PriceMinPerUnit = 440, Location = "Popayán (Cauca)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 987, Product = product57, Unit = unit3, PriceAvgPerUnit = 680, PriceMaxPerUnit = 760, PriceMinPerUnit = 600, Location = "Valledupar, Mercado Nuevo", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 988, Product = product57, Unit = unit3, PriceAvgPerUnit = 560, PriceMaxPerUnit = 560, PriceMinPerUnit = 560, Location = "Neiva, Surabastos", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 989, Product = product57, Unit = unit3, PriceAvgPerUnit = 1000, PriceMaxPerUnit = 1000, PriceMinPerUnit = 1000, Location = "Villavicencio (Meta)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 990, Product = product57, Unit = unit3, PriceAvgPerUnit = 800, PriceMaxPerUnit = 800, PriceMinPerUnit = 800, Location = "Cúcuta, Cenabastos", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 991, Product = product57, Unit = unit3, PriceAvgPerUnit = 500, PriceMaxPerUnit = 500, PriceMinPerUnit = 500, Location = "Armenia, Mercar", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 992, Product = product57, Unit = unit3, PriceAvgPerUnit = 667, PriceMaxPerUnit = 700, PriceMinPerUnit = 600, Location = "Pereira, Mercasa", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 993, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Pereira, La 41", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 994, Product = product57, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "San Gil (Santander)", Created = DateTime.ParseExact("2014-08-16", "yyyy-MM-dd", null) },
new Price {Id = 995, Product = product57, Unit = unit3, PriceAvgPerUnit = 650, PriceMaxPerUnit = 700, PriceMinPerUnit = 600, Location = "Socorro (Santander)", Created = DateTime.ParseExact("2014-08-30", "yyyy-MM-dd", null) },
new Price {Id = 996, Product = product57, Unit = unit3, PriceAvgPerUnit = 1031, PriceMaxPerUnit = 1200, PriceMinPerUnit = 920, Location = "Sincelejo (Sucre)", Created = DateTime.ParseExact("2014-09-13", "yyyy-MM-dd", null) },
new Price {Id = 997, Product = product1, Unit = unit3, PriceAvgPerUnit = 405, PriceMaxPerUnit = 600, PriceMinPerUnit = 300, Location = "Bogotá, D.C., Corabastos", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) },
new Price {Id = 998, Product = product1, Unit = unit3, PriceAvgPerUnit = 990, PriceMaxPerUnit = 1000, PriceMinPerUnit = 900, Location = "Tunja (Boyacá)", Created = DateTime.ParseExact("2014-08-09", "yyyy-MM-dd", null) },
new Price {Id = 999, Product = product1, Unit = unit3, PriceAvgPerUnit = 1500, PriceMaxPerUnit = 1667, PriceMinPerUnit = 1333, Location = "Chiquinquirá (Boyacá)", Created = DateTime.ParseExact("2014-08-23", "yyyy-MM-dd", null) },
new Price {Id = 1000, Product = product1, Unit = unit3, PriceAvgPerUnit = 700, PriceMaxPerUnit = 700, PriceMinPerUnit = 700, Location = "Duitama (Boyacá)", Created = DateTime.ParseExact("2014-09-06", "yyyy-MM-dd", null) }
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
