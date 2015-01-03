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
            context.Places.AddOrUpdate(
                pl => pl.Id,
new Place { Code = "05", IsoCode = "05", Name = "ANTIOQUIA", Latitude = 6.24894080956, Longitude = -75.5770556256 },
new Place { Code = "08", IsoCode = "08", Name = "ATLÁNTICO", Latitude = 10.9796493947, Longitude = -74.8187880943 },
new Place { Code = "11", IsoCode = "11", Name = "BOGOTÁ, D. C.", Latitude = 4.62457504964, Longitude = -74.1139187163 },
new Place { Code = "13", IsoCode = "13", Name = "BOLÍVAR", Latitude = 10.3988164844, Longitude = -75.501229216 },
new Place { Code = "15", IsoCode = "15", Name = "BOYACÁ", Latitude = 5.53937063584, Longitude = -73.3543638186 },
new Place { Code = "17", IsoCode = "17", Name = "CALDAS", Latitude = 5.05705056379, Longitude = -75.4904150625 },
new Place { Code = "18", IsoCode = "18", Name = "CAQUETÁ", Latitude = 1.61582907928, Longitude = -75.6079932658 },
new Place { Code = "19", IsoCode = "19", Name = "CAUCA", Latitude = 2.44823960489, Longitude = -76.624787641 },
new Place { Code = "20", IsoCode = "20", Name = "CESAR", Latitude = 10.4615184337, Longitude = -73.2586483431 },
new Place { Code = "23", IsoCode = "23", Name = "CÓRDOBA", Latitude = 8.74991666326, Longitude = -75.8956393314 },
new Place { Code = "25", IsoCode = "25", Name = "CUNDINAMARCA", Latitude = 4.37585313348, Longitude = -74.6695456055 },
new Place { Code = "27", IsoCode = "27", Name = "CHOCÓ", Latitude = 5.69234946505, Longitude = -76.6511246326 },
new Place { Code = "41", IsoCode = "41", Name = "HUILA", Latitude = 2.93554559251, Longitude = -75.2779458694 },
new Place { Code = "44", IsoCode = "44", Name = "LA GUAJIRA", Latitude = 11.5291254274, Longitude = -72.9122712549 },
new Place { Code = "47", IsoCode = "47", Name = "MAGDALENA", Latitude = 11.2257031416, Longitude = -74.1883970496 },
new Place { Code = "50", IsoCode = "50", Name = "META", Latitude = 4.12295758045, Longitude = -73.626877897 },
new Place { Code = "52", IsoCode = "52", Name = "NARIÑO", Latitude = 1.21280859722, Longitude = -77.2782674539 },
new Place { Code = "54", IsoCode = "54", Name = "NORTE DE SANTANDER", Latitude = 7.90526711655, Longitude = -72.5055909659 },
new Place { Code = "63", IsoCode = "63", Name = "QUINDÍO", Latitude = 4.53805331619, Longitude = -75.6762454094 },
new Place { Code = "66", IsoCode = "66", Name = "RISARALDA", Latitude = 4.80888773215, Longitude = -75.7155099202 },
new Place { Code = "68", IsoCode = "68", Name = "SANTANDER", Latitude = 7.12278728534, Longitude = -73.132325231 },
new Place { Code = "70", IsoCode = "70", Name = "SUCRE", Latitude = 9.30015762595, Longitude = -75.385219416 },
new Place { Code = "73", IsoCode = "73", Name = "TOLIMA", Latitude = 4.4396307255, Longitude = -75.1963501468 },
new Place { Code = "76", IsoCode = "76", Name = "VALLE DEL CAUCA", Latitude = 3.40638218413, Longitude = -76.5263911952 },
new Place { Code = "81", IsoCode = "81", Name = "ARAUCA", Latitude = 7.07773650197, Longitude = -70.762773048 },
new Place { Code = "85", IsoCode = "85", Name = "CASANARE", Latitude = 5.33249117563, Longitude = -72.3937905332 },
new Place { Code = "86", IsoCode = "86", Name = "PUTUMAYO", Latitude = 1.14428450756, Longitude = -76.6519175009 },
new Place { Code = "88", IsoCode = "88", Name = "ARCHIPIÉLAGO DE SAN ANDRÉS Y PROVIDENCIA", Latitude = 12.5829884179, Longitude = -81.6960414806 },
new Place { Code = "91", IsoCode = "91", Name = "AMAZONAS", Latitude = -4.21202316969, Longitude = -69.9406798289 },
new Place { Code = "94", IsoCode = "94", Name = "GUAINÍA", Latitude = 3.87032554774, Longitude = -67.918283684 },
new Place { Code = "95", IsoCode = "95", Name = "GUAVIARE", Latitude = 2.57047809895, Longitude = -72.6400959977 },
new Place { Code = "97", IsoCode = "97", Name = "VAUPÉS", Latitude = 1.25117078854, Longitude = -70.2349602618 },
new Place { Code = "99", IsoCode = "99", Name = "VICHADA", Latitude = 6.18560656721, Longitude = -67.4855961 },
new Place { Code = "05001", IsoCode = "05001", Name = "MEDELLÍN - ANTIOQUIA", Latitude = 6.24894080956, Longitude = -75.5770556256 },
new Place { Code = "05002", IsoCode = "05002", Name = "ABEJORRAL - ANTIOQUIA", Latitude = 5.78953996024, Longitude = -75.4289204217 },
new Place { Code = "05004", IsoCode = "05004", Name = "ABRIAQUÍ - ANTIOQUIA", Latitude = 6.6339560277, Longitude = -76.0631582653 },
new Place { Code = "05021", IsoCode = "05021", Name = "ALEJANDRÍA - ANTIOQUIA", Latitude = 6.37447380153, Longitude = -75.1430974124 },
new Place { Code = "05030", IsoCode = "05030", Name = "AMAGÁ - ANTIOQUIA", Latitude = 6.03583351331, Longitude = -75.7017624652 },
new Place { Code = "05031", IsoCode = "05031", Name = "AMALFI - ANTIOQUIA", Latitude = 6.90887428957, Longitude = -75.073147584 },
new Place { Code = "05034", IsoCode = "05034", Name = "ANDES - ANTIOQUIA", Latitude = 5.65688469544, Longitude = -75.879251019 },
new Place { Code = "05036", IsoCode = "05036", Name = "ANGELÓPOLIS - ANTIOQUIA", Latitude = 6.11188033761, Longitude = -75.708330776 },
new Place { Code = "05038", IsoCode = "05038", Name = "ANGOSTURA - ANTIOQUIA", Latitude = 6.88536619294, Longitude = -75.3349479888 },
new Place { Code = "05040", IsoCode = "05040", Name = "ANORÍ - ANTIOQUIA", Latitude = 7.07800833332, Longitude = -75.1483999002 },
new Place { Code = "05042", IsoCode = "05042", Name = "SANTA FÉ DE ANTIOQUIA - ANTIOQUIA", Latitude = 6.5582689862, Longitude = -75.8272323818 },
new Place { Code = "05044", IsoCode = "05044", Name = "ANZÁ - ANTIOQUIA", Latitude = 6.30223046843, Longitude = -75.853713332 },
new Place { Code = "05045", IsoCode = "05045", Name = "APARTADÓ - ANTIOQUIA", Latitude = 7.88271669622, Longitude = -76.6261859724 },
new Place { Code = "05051", IsoCode = "05051", Name = "ARBOLETES - ANTIOQUIA", Latitude = 8.85000626596, Longitude = -76.4266804048 },
new Place { Code = "05055", IsoCode = "05055", Name = "ARGELIA - ANTIOQUIA", Latitude = 5.73036774762, Longitude = -75.1391944342 },
new Place { Code = "05059", IsoCode = "05059", Name = "ARMENIA - ANTIOQUIA", Latitude = 6.15581919451, Longitude = -75.7865604641 },
new Place { Code = "05079", IsoCode = "05079", Name = "BARBOSA - ANTIOQUIA", Latitude = 6.43798866193, Longitude = -75.3338190533 },
new Place { Code = "05086", IsoCode = "05086", Name = "BELMIRA - ANTIOQUIA", Latitude = 6.60617594414, Longitude = -75.6682148634 },
new Place { Code = "05088", IsoCode = "05088", Name = "BELLO - ANTIOQUIA", Latitude = 6.33378556247, Longitude = -75.5544475761 },
new Place { Code = "05091", IsoCode = "05091", Name = "BETANIA - ANTIOQUIA", Latitude = 5.74921425848, Longitude = -75.9817693681 },
new Place { Code = "05093", IsoCode = "05093", Name = "BETULIA - ANTIOQUIA", Latitude = 6.10909980708, Longitude = -75.9841907479 },
new Place { Code = "05101", IsoCode = "05101", Name = "CIUDAD BOLÍVAR - ANTIOQUIA", Latitude = 5.84651700067, Longitude = -76.0133228121 },
new Place { Code = "05107", IsoCode = "05107", Name = "BRICEÑO - ANTIOQUIA", Latitude = 7.11279053594, Longitude = -75.550660382 },
new Place { Code = "05113", IsoCode = "05113", Name = "BURITICÁ - ANTIOQUIA", Latitude = 6.71988421942, Longitude = -75.9062641102 },
new Place { Code = "05120", IsoCode = "05120", Name = "CÁCERES - ANTIOQUIA", Latitude = 7.57506519303, Longitude = -75.3529801717 },
new Place { Code = "05125", IsoCode = "05125", Name = "CAICEDO - ANTIOQUIA", Latitude = 6.40578758966, Longitude = -75.984153352 },
new Place { Code = "05129", IsoCode = "05129", Name = "CALDAS - ANTIOQUIA", Latitude = 6.0915778464, Longitude = -75.6344938043 },
new Place { Code = "05134", IsoCode = "05134", Name = "CAMPAMENTO - ANTIOQUIA", Latitude = 6.97898982025, Longitude = -75.2953334406 },
new Place { Code = "05138", IsoCode = "05138", Name = "CAÑASGORDAS - ANTIOQUIA", Latitude = 6.75976724617, Longitude = -76.0302047407 },
new Place { Code = "05142", IsoCode = "05142", Name = "CARACOLÍ - ANTIOQUIA", Latitude = 6.40250922802, Longitude = -74.7592025032 },
new Place { Code = "05145", IsoCode = "05145", Name = "CARAMANTA - ANTIOQUIA", Latitude = 5.54909478613, Longitude = -75.6453315664 },
new Place { Code = "05147", IsoCode = "05147", Name = "CAREPA - ANTIOQUIA", Latitude = 7.75420419468, Longitude = -76.6531189552 },
new Place { Code = "05148", IsoCode = "05148", Name = "EL CARMEN DE VIBORAL - ANTIOQUIA", Latitude = 6.08497157368, Longitude = -75.335269012 },
new Place { Code = "05150", IsoCode = "05150", Name = "CAROLINA - ANTIOQUIA", Latitude = 6.72599435248, Longitude = -75.2835999381 },
new Place { Code = "05154", IsoCode = "05154", Name = "CAUCASIA - ANTIOQUIA", Latitude = 7.97776036994, Longitude = -75.1985143435 },
new Place { Code = "05172", IsoCode = "05172", Name = "CHIGORODÓ - ANTIOQUIA", Latitude = 7.66615644949, Longitude = -76.6815647246 },
new Place { Code = "05190", IsoCode = "05190", Name = "CISNEROS - ANTIOQUIA", Latitude = 6.53887519896, Longitude = -75.0862390602 },
new Place { Code = "05197", IsoCode = "05197", Name = "COCORNÁ - ANTIOQUIA", Latitude = 6.05788879642, Longitude = -75.1856126097 },
new Place { Code = "05206", IsoCode = "05206", Name = "CONCEPCIÓN - ANTIOQUIA", Latitude = 6.39397607889, Longitude = -75.256527061 },
new Place { Code = "05209", IsoCode = "05209", Name = "CONCORDIA - ANTIOQUIA", Latitude = 6.04714827298, Longitude = -75.9082819051 },
new Place { Code = "05212", IsoCode = "05212", Name = "COPACABANA - ANTIOQUIA", Latitude = 6.35822753091, Longitude = -75.5024226761 },
new Place { Code = "05234", IsoCode = "05234", Name = "DABEIBA - ANTIOQUIA", Latitude = 7.00003402635, Longitude = -76.2629740972 },
new Place { Code = "05237", IsoCode = "05237", Name = "DONMATÍAS - ANTIOQUIA", Latitude = 6.48588534626, Longitude = -75.3940951645 },
new Place { Code = "05240", IsoCode = "05240", Name = "EBÉJICO - ANTIOQUIA", Latitude = 6.327259705, Longitude = -75.7668777263 },
new Place { Code = "05250", IsoCode = "05250", Name = "EL BAGRE - ANTIOQUIA", Latitude = 7.59295465249, Longitude = -74.8047104261 },
new Place { Code = "05264", IsoCode = "05264", Name = "ENTRERRÍOS - ANTIOQUIA", Latitude = 6.56665004926, Longitude = -75.5171548466 },
new Place { Code = "05266", IsoCode = "05266", Name = "ENVIGADO - ANTIOQUIA", Latitude = 6.16666179755, Longitude = -75.5831907344 },
new Place { Code = "05282", IsoCode = "05282", Name = "FREDONIA - ANTIOQUIA", Latitude = 5.92484004201, Longitude = -75.671166144 },
new Place { Code = "05284", IsoCode = "05284", Name = "FRONTINO - ANTIOQUIA", Latitude = 6.77558501432, Longitude = -76.1312233969 },
new Place { Code = "05306", IsoCode = "05306", Name = "GIRALDO - ANTIOQUIA", Latitude = 6.67830122959, Longitude = -75.9497722759 },
new Place { Code = "05308", IsoCode = "05308", Name = "GIRARDOTA - ANTIOQUIA", Latitude = 6.37934992894, Longitude = -75.4436989853 },
new Place { Code = "05310", IsoCode = "05310", Name = "GÓMEZ PLATA - ANTIOQUIA", Latitude = 6.68411944774, Longitude = -75.2217555544 },
new Place { Code = "05313", IsoCode = "05313", Name = "GRANADA - ANTIOQUIA", Latitude = 6.14137433235, Longitude = -75.187972674 },
new Place { Code = "05315", IsoCode = "05315", Name = "GUADALUPE - ANTIOQUIA", Latitude = 6.81504821632, Longitude = -75.2397174083 },
new Place { Code = "05318", IsoCode = "05318", Name = "GUARNE - ANTIOQUIA", Latitude = 6.27897889751, Longitude = -75.4400880378 },
new Place { Code = "05321", IsoCode = "05321", Name = "GUATAPÉ - ANTIOQUIA", Latitude = 6.23233737137, Longitude = -75.1556269715 },
new Place { Code = "05347", IsoCode = "05347", Name = "HELICONIA - ANTIOQUIA", Latitude = 6.20603288366, Longitude = -75.7347859901 },
new Place { Code = "05353", IsoCode = "05353", Name = "HISPANIA - ANTIOQUIA", Latitude = 5.7988794992, Longitude = -75.9049374881 },
new Place { Code = "05360", IsoCode = "05360", Name = "ITAGÜÍ - ANTIOQUIA", Latitude = 6.16815830322, Longitude = -75.629721946 },
new Place { Code = "05361", IsoCode = "05361", Name = "ITUANGO - ANTIOQUIA", Latitude = 7.17162301036, Longitude = -75.76416656 },
new Place { Code = "05364", IsoCode = "05364", Name = "JARDÍN - ANTIOQUIA", Latitude = 5.6009650382, Longitude = -75.8230669283 },
new Place { Code = "05368", IsoCode = "05368", Name = "JERICÓ - ANTIOQUIA", Latitude = 5.79245557634, Longitude = -75.784627705 },
new Place { Code = "05376", IsoCode = "05376", Name = "LA CEJA - ANTIOQUIA", Latitude = 6.03259036572, Longitude = -75.4216378862 },
new Place { Code = "05380", IsoCode = "05380", Name = "LA ESTRELLA - ANTIOQUIA", Latitude = 6.15839094042, Longitude = -75.6451870672 },
new Place { Code = "05390", IsoCode = "05390", Name = "LA PINTADA - ANTIOQUIA", Latitude = 5.73913585414, Longitude = -75.6062180593 },
new Place { Code = "05400", IsoCode = "05400", Name = "LA UNIÓN - ANTIOQUIA", Latitude = 5.97435177167, Longitude = -75.3605747077 },
new Place { Code = "05411", IsoCode = "05411", Name = "LIBORINA - ANTIOQUIA", Latitude = 6.6763586892, Longitude = -75.8136759627 },
new Place { Code = "05425", IsoCode = "05425", Name = "MACEO - ANTIOQUIA", Latitude = 6.55311608541, Longitude = -74.787847715 },
new Place { Code = "05440", IsoCode = "05440", Name = "MARINILLA - ANTIOQUIA", Latitude = 6.1735481398, Longitude = -75.3380784357 },
new Place { Code = "05467", IsoCode = "05467", Name = "MONTEBELLO - ANTIOQUIA", Latitude = 5.94656365917, Longitude = -75.5237539337 },
new Place { Code = "05475", IsoCode = "05475", Name = "MURINDÓ - ANTIOQUIA", Latitude = 6.97696716669, Longitude = -76.8199865212 },
new Place { Code = "05480", IsoCode = "05480", Name = "MUTATÁ - ANTIOQUIA", Latitude = 7.24396317282, Longitude = -76.4367046955 },
new Place { Code = "05483", IsoCode = "05483", Name = "NARIÑO - ANTIOQUIA", Latitude = 5.61099552193, Longitude = -75.1749212942 },
new Place { Code = "05490", IsoCode = "05490", Name = "NECOCLÍ - ANTIOQUIA", Latitude = 8.42602528099, Longitude = -76.7876212535 },
new Place { Code = "05495", IsoCode = "05495", Name = "NECHÍ - ANTIOQUIA", Latitude = 8.08874643365, Longitude = -74.7763395888 },
new Place { Code = "05501", IsoCode = "05501", Name = "OLAYA - ANTIOQUIA", Latitude = 6.624511889, Longitude = -75.8112765589 },
new Place { Code = "05541", IsoCode = "05541", Name = "PEÑOL - ANTIOQUIA", Latitude = 6.2216831826, Longitude = -75.2123722544 },
new Place { Code = "05543", IsoCode = "05543", Name = "PEQUE - ANTIOQUIA", Latitude = 7.02209987188, Longitude = -75.9086712096 },
new Place { Code = "05576", IsoCode = "05576", Name = "PUEBLORRICO - ANTIOQUIA", Latitude = 5.79341608531, Longitude = -75.8405778432 },
new Place { Code = "05579", IsoCode = "05579", Name = "PUERTO BERRÍO - ANTIOQUIA", Latitude = 6.4900665391, Longitude = -74.4046363087 },
new Place { Code = "05585", IsoCode = "05585", Name = "PUERTO NARE - ANTIOQUIA", Latitude = 6.18204690082, Longitude = -74.5851321578 },
new Place { Code = "05591", IsoCode = "05591", Name = "PUERTO TRIUNFO - ANTIOQUIA", Latitude = 5.88820840277, Longitude = -74.6340235664 },
new Place { Code = "05604", IsoCode = "05604", Name = "REMEDIOS - ANTIOQUIA", Latitude = 7.0287935872, Longitude = -74.6904627996 },
new Place { Code = "05607", IsoCode = "05607", Name = "RETIRO - ANTIOQUIA", Latitude = 6.06324258169, Longitude = -75.5020105794 },
new Place { Code = "05615", IsoCode = "05615", Name = "RIONEGRO - ANTIOQUIA", Latitude = 6.14622006041, Longitude = -75.3762557551 },
new Place { Code = "05628", IsoCode = "05628", Name = "SABANALARGA - ANTIOQUIA", Latitude = 6.85353316387, Longitude = -75.814165993 },
new Place { Code = "05631", IsoCode = "05631", Name = "SABANETA - ANTIOQUIA", Latitude = 6.15089231663, Longitude = -75.6153508751 },
new Place { Code = "05642", IsoCode = "05642", Name = "SALGAR - ANTIOQUIA", Latitude = 5.96116241719, Longitude = -75.9754359618 },
new Place { Code = "05647", IsoCode = "05647", Name = "SAN ANDRÉS DE CUERQUÍA - ANTIOQUIA", Latitude = 6.92360963908, Longitude = -75.6727731197 },
new Place { Code = "05649", IsoCode = "05649", Name = "SAN CARLOS - ANTIOQUIA", Latitude = 6.18797640741, Longitude = -74.9930024004 },
new Place { Code = "05652", IsoCode = "05652", Name = "SAN FRANCISCO - ANTIOQUIA", Latitude = 5.9641723934, Longitude = -75.101852968 },
new Place { Code = "05656", IsoCode = "05656", Name = "SAN JERÓNIMO - ANTIOQUIA", Latitude = 6.44306379215, Longitude = -75.7278178256 },
new Place { Code = "05658", IsoCode = "05658", Name = "SAN JOSÉ DE LA MONTAÑA - ANTIOQUIA", Latitude = 6.84974120672, Longitude = -75.6840821906 },
new Place { Code = "05659", IsoCode = "05659", Name = "SAN JUAN DE URABÁ - ANTIOQUIA", Latitude = 8.75949060532, Longitude = -76.5288897941 },
new Place { Code = "05660", IsoCode = "05660", Name = "SAN LUIS - ANTIOQUIA", Latitude = 6.04286525406, Longitude = -74.9943922308 },
new Place { Code = "05664", IsoCode = "05664", Name = "SAN PEDRO DE LOS MILAGROS - ANTIOQUIA", Latitude = 6.46043452078, Longitude = -75.5609117195 },
new Place { Code = "05665", IsoCode = "05665", Name = "SAN PEDRO DE URABÁ - ANTIOQUIA", Latitude = 8.27806430733, Longitude = -76.3825621279 },
new Place { Code = "05667", IsoCode = "05667", Name = "SAN RAFAEL - ANTIOQUIA", Latitude = 6.29394973638, Longitude = -75.0282495206 },
new Place { Code = "05670", IsoCode = "05670", Name = "SAN ROQUE - ANTIOQUIA", Latitude = 6.48481184945, Longitude = -75.0222636421 },
new Place { Code = "05674", IsoCode = "05674", Name = "SAN VICENTE FERRER - ANTIOQUIA", Latitude = 6.27940487148, Longitude = -75.3347960432 },
new Place { Code = "05679", IsoCode = "05679", Name = "SANTA BÁRBARA - ANTIOQUIA", Latitude = 5.8806391227, Longitude = -75.5723194638 },
new Place { Code = "05686", IsoCode = "05686", Name = "SANTA ROSA DE OSOS - ANTIOQUIA", Latitude = 6.64517249597, Longitude = -75.46007968 },
new Place { Code = "05690", IsoCode = "05690", Name = "SANTO DOMINGO - ANTIOQUIA", Latitude = 6.47478461773, Longitude = -75.1677488199 },
new Place { Code = "05697", IsoCode = "05697", Name = "EL SANTUARIO - ANTIOQUIA", Latitude = 6.13596027701, Longitude = -75.2613936054 },
new Place { Code = "05736", IsoCode = "05736", Name = "SEGOVIA - ANTIOQUIA", Latitude = 7.08108247705, Longitude = -74.6990624579 },
new Place { Code = "05756", IsoCode = "05756", Name = "SONSÓN - ANTIOQUIA", Latitude = 5.71278805376, Longitude = -75.3103024361 },
new Place { Code = "05761", IsoCode = "05761", Name = "SOPETRÁN - ANTIOQUIA", Latitude = 6.50313220449, Longitude = -75.745937366 },
new Place { Code = "05789", IsoCode = "05789", Name = "TÁMESIS - ANTIOQUIA", Latitude = 5.66517675836, Longitude = -75.7142215352 },
new Place { Code = "05790", IsoCode = "05790", Name = "TARAZÁ - ANTIOQUIA", Latitude = 7.58161135295, Longitude = -75.3997109965 },
new Place { Code = "05792", IsoCode = "05792", Name = "TARSO - ANTIOQUIA", Latitude = 5.8654485824, Longitude = -75.8227902131 },
new Place { Code = "05809", IsoCode = "05809", Name = "TITIRIBÍ - ANTIOQUIA", Latitude = 6.06294586497, Longitude = -75.7947081203 },
new Place { Code = "05819", IsoCode = "05819", Name = "TOLEDO - ANTIOQUIA", Latitude = 7.01034191618, Longitude = -75.6921665411 },
new Place { Code = "05837", IsoCode = "05837", Name = "TURBO - ANTIOQUIA", Latitude = 8.094096738, Longitude = -76.7264318312 },
new Place { Code = "05842", IsoCode = "05842", Name = "URAMITA - ANTIOQUIA", Latitude = 6.89359302294, Longitude = -76.1704105356 },
new Place { Code = "05847", IsoCode = "05847", Name = "URRAO - ANTIOQUIA", Latitude = 6.31400117617, Longitude = -76.132240466 },
new Place { Code = "05854", IsoCode = "05854", Name = "VALDIVIA - ANTIOQUIA", Latitude = 7.16313768064, Longitude = -75.4397119153 },
new Place { Code = "05856", IsoCode = "05856", Name = "VALPARAÍSO - ANTIOQUIA", Latitude = 5.61469852347, Longitude = -75.6247151951 },
new Place { Code = "05858", IsoCode = "05858", Name = "VEGACHÍ - ANTIOQUIA", Latitude = 6.76716219931, Longitude = -74.7932517607 },
new Place { Code = "05861", IsoCode = "05861", Name = "VENECIA - ANTIOQUIA", Latitude = 5.96308592567, Longitude = -75.7345341046 },
new Place { Code = "05873", IsoCode = "05873", Name = "VIGÍA DEL FUERTE - ANTIOQUIA", Latitude = 6.5887941127, Longitude = -76.8963475885 },
new Place { Code = "05885", IsoCode = "05885", Name = "YALÍ - ANTIOQUIA", Latitude = 6.66825257998, Longitude = -74.8411747571 },
new Place { Code = "05887", IsoCode = "05887", Name = "YARUMAL - ANTIOQUIA", Latitude = 6.96557970001, Longitude = -75.4195984062 },
new Place { Code = "05890", IsoCode = "05890", Name = "YOLOMBÓ - ANTIOQUIA", Latitude = 6.59468858167, Longitude = -75.0135287985 },
new Place { Code = "05893", IsoCode = "05893", Name = "YONDÓ - ANTIOQUIA", Latitude = 7.00260352994, Longitude = -73.9098900752 },
new Place { Code = "05895", IsoCode = "05895", Name = "ZARAGOZA - ANTIOQUIA", Latitude = 7.488149672, Longitude = -74.8679617402 },
new Place { Code = "08001", IsoCode = "08001", Name = "BARRANQUILLA - ATLÁNTICO", Latitude = 10.9796493947, Longitude = -74.8187880943 },
new Place { Code = "08078", IsoCode = "08078", Name = "BARANOA - ATLÁNTICO", Latitude = 10.7899331958, Longitude = -74.9181077454 },
new Place { Code = "08137", IsoCode = "08137", Name = "CAMPO DE LA CRUZ - ATLÁNTICO", Latitude = 10.3786231059, Longitude = -74.8812519551 },
new Place { Code = "08141", IsoCode = "08141", Name = "CANDELARIA - ATLÁNTICO", Latitude = 10.4591778633, Longitude = -74.8791248338 },
new Place { Code = "08296", IsoCode = "08296", Name = "GALAPA - ATLÁNTICO", Latitude = 10.9042960533, Longitude = -74.8831352334 },
new Place { Code = "08372", IsoCode = "08372", Name = "JUAN DE ACOSTA - ATLÁNTICO", Latitude = 10.8299007844, Longitude = -75.0321458392 },
new Place { Code = "08421", IsoCode = "08421", Name = "LURUACO - ATLÁNTICO", Latitude = 10.6108621963, Longitude = -75.1423516448 },
new Place { Code = "08433", IsoCode = "08433", Name = "MALAMBO - ATLÁNTICO", Latitude = 10.8346127213, Longitude = -74.766488746 },
new Place { Code = "08436", IsoCode = "08436", Name = "MANATÍ - ATLÁNTICO", Latitude = 10.4470465577, Longitude = -74.9594114052 },
new Place { Code = "08520", IsoCode = "08520", Name = "PALMAR DE VARELA - ATLÁNTICO", Latitude = 10.740602082, Longitude = -74.7537459302 },
new Place { Code = "08549", IsoCode = "08549", Name = "PIOJÓ - ATLÁNTICO", Latitude = 10.7492003136, Longitude = -75.1080656321 },
new Place { Code = "08558", IsoCode = "08558", Name = "POLONUEVO - ATLÁNTICO", Latitude = 10.7769967553, Longitude = -74.8538865194 },
new Place { Code = "08560", IsoCode = "08560", Name = "PONEDERA - ATLÁNTICO", Latitude = 10.6419178279, Longitude = -74.7493964437 },
new Place { Code = "08573", IsoCode = "08573", Name = "PUERTO COLOMBIA - ATLÁNTICO", Latitude = 10.9855255232, Longitude = -74.9587617808 },
new Place { Code = "08606", IsoCode = "08606", Name = "REPELÓN - ATLÁNTICO", Latitude = 10.4943070644, Longitude = -75.1245913597 },
new Place { Code = "08634", IsoCode = "08634", Name = "SABANAGRANDE - ATLÁNTICO", Latitude = 10.7907678504, Longitude = -74.7568486996 },
new Place { Code = "08638", IsoCode = "08638", Name = "SABANALARGA - ATLÁNTICO", Latitude = 10.6338334111, Longitude = -74.9206251244 },
new Place { Code = "08675", IsoCode = "08675", Name = "SANTA LUCÍA - ATLÁNTICO", Latitude = 10.3262870931, Longitude = -74.9637240647 },
new Place { Code = "08685", IsoCode = "08685", Name = "SANTO TOMÁS - ATLÁNTICO", Latitude = 10.7580629353, Longitude = -74.7524390475 },
new Place { Code = "08758", IsoCode = "08758", Name = "SOLEDAD - ATLÁNTICO", Latitude = 10.9056320841, Longitude = -74.7923421864 },
new Place { Code = "08770", IsoCode = "08770", Name = "SUAN - ATLÁNTICO", Latitude = 10.3336984851, Longitude = -74.8801231433 },
new Place { Code = "08832", IsoCode = "08832", Name = "TUBARÁ - ATLÁNTICO", Latitude = 10.8739845528, Longitude = -74.9786114088 },
new Place { Code = "08849", IsoCode = "08849", Name = "USIACURÍ - ATLÁNTICO", Latitude = 10.7427773208, Longitude = -74.9769331063 },
new Place { Code = "11001", IsoCode = "11001", Name = "BOGOTÁ, D.C. - BOGOTÁ, D. C.", Latitude = 4.62457504964, Longitude = -74.1139187163 },
new Place { Code = "13001", IsoCode = "13001", Name = "CARTAGENA DE INDIAS - BOLÍVAR", Latitude = 10.3988164844, Longitude = -75.501229216 },
new Place { Code = "13006", IsoCode = "13006", Name = "ACHÍ - BOLÍVAR", Latitude = 8.56785243037, Longitude = -74.555491768 },
new Place { Code = "13030", IsoCode = "13030", Name = "ALTOS DEL ROSARIO - BOLÍVAR", Latitude = 8.79246616099, Longitude = -74.1652349915 },
new Place { Code = "13042", IsoCode = "13042", Name = "ARENAL - BOLÍVAR", Latitude = 8.4591438374, Longitude = -73.9432783651 },
new Place { Code = "13052", IsoCode = "13052", Name = "ARJONA - BOLÍVAR", Latitude = 10.2572499523, Longitude = -75.3455275963 },
new Place { Code = "13062", IsoCode = "13062", Name = "ARROYOHONDO - BOLÍVAR", Latitude = 10.2518817293, Longitude = -75.0197602573 },
new Place { Code = "13074", IsoCode = "13074", Name = "BARRANCO DE LOBA - BOLÍVAR", Latitude = 8.94457766052, Longitude = -74.1031310793 },
new Place { Code = "13140", IsoCode = "13140", Name = "CALAMAR - BOLÍVAR", Latitude = 10.2510248106, Longitude = -74.9138095675 },
new Place { Code = "13160", IsoCode = "13160", Name = "CANTAGALLO - BOLÍVAR", Latitude = 7.37289896302, Longitude = -73.9244280444 },
new Place { Code = "13188", IsoCode = "13188", Name = "CICUCO - BOLÍVAR", Latitude = 9.27539872866, Longitude = -74.6455241002 },
new Place { Code = "13212", IsoCode = "13212", Name = "CÓRDOBA - BOLÍVAR", Latitude = 9.5866229951, Longitude = -74.8275074563 },
new Place { Code = "13222", IsoCode = "13222", Name = "CLEMENCIA - BOLÍVAR", Latitude = 10.5676323296, Longitude = -75.3256686196 },
new Place { Code = "13244", IsoCode = "13244", Name = "EL CARMEN DE BOLÍVAR - BOLÍVAR", Latitude = 9.71803422099, Longitude = -75.1211388325 },
new Place { Code = "13248", IsoCode = "13248", Name = "EL GUAMO - BOLÍVAR", Latitude = 10.0322476608, Longitude = -74.9756441963 },
new Place { Code = "13268", IsoCode = "13268", Name = "EL PEÑÓN - BOLÍVAR", Latitude = 8.98905859225, Longitude = -73.9497518752 },
new Place { Code = "13300", IsoCode = "13300", Name = "HATILLO DE LOBA - BOLÍVAR", Latitude = 8.95590428022, Longitude = -74.0754398318 },
new Place { Code = "13430", IsoCode = "13430", Name = "MAGANGUÉ - BOLÍVAR", Latitude = 9.24136746631, Longitude = -74.7556678557 },
new Place { Code = "13433", IsoCode = "13433", Name = "MAHATES - BOLÍVAR", Latitude = 10.2331675046, Longitude = -75.1906885946 },
new Place { Code = "13440", IsoCode = "13440", Name = "MARGARITA - BOLÍVAR", Latitude = 9.15914023623, Longitude = -74.293740633 },
new Place { Code = "13442", IsoCode = "13442", Name = "MARÍA LA BAJA - BOLÍVAR", Latitude = 9.98513343931, Longitude = -75.3032014543 },
new Place { Code = "13458", IsoCode = "13458", Name = "MONTECRISTO - BOLÍVAR", Latitude = 8.29331961016, Longitude = -74.4758024507 },
new Place { Code = "13468", IsoCode = "13468", Name = "MOMPÓS - BOLÍVAR", Latitude = 9.24102197372, Longitude = -74.4257994296 },
new Place { Code = "13473", IsoCode = "13473", Name = "MORALES - BOLÍVAR", Latitude = 8.27511976232, Longitude = -73.867563939 },
new Place { Code = "13490", IsoCode = "13490", Name = "NOROSÍ - BOLÍVAR", Latitude = 8.52787744125, Longitude = -74.0372601001 },
new Place { Code = "13549", IsoCode = "13549", Name = "PINILLOS - BOLÍVAR", Latitude = 8.91622811147, Longitude = -74.4642008643 },
new Place { Code = "13580", IsoCode = "13580", Name = "REGIDOR - BOLÍVAR", Latitude = 8.66613059325, Longitude = -73.8222028937 },
new Place { Code = "13600", IsoCode = "13600", Name = "RÍO VIEJO - BOLÍVAR", Latitude = 8.58918472541, Longitude = -73.8376744606 },
new Place { Code = "13620", IsoCode = "13620", Name = "SAN CRISTÓBAL - BOLÍVAR", Latitude = 10.3938259563, Longitude = -75.0632935783 },
new Place { Code = "13647", IsoCode = "13647", Name = "SAN ESTANISLAO - BOLÍVAR", Latitude = 10.3982507972, Longitude = -75.1500702017 },
new Place { Code = "13650", IsoCode = "13650", Name = "SAN FERNANDO - BOLÍVAR", Latitude = 9.21887135796, Longitude = -74.3349148269 },
new Place { Code = "13654", IsoCode = "13654", Name = "SAN JACINTO - BOLÍVAR", Latitude = 9.83065775253, Longitude = -75.1217447993 },
new Place { Code = "13655", IsoCode = "13655", Name = "SAN JACINTO DEL CAUCA - BOLÍVAR", Latitude = 8.24948231979, Longitude = -74.7235512387 },
new Place { Code = "13657", IsoCode = "13657", Name = "SAN JUAN NEPOMUCENO - BOLÍVAR", Latitude = 9.95138127677, Longitude = -75.0836663042 },
new Place { Code = "13667", IsoCode = "13667", Name = "SAN MARTÍN DE LOBA - BOLÍVAR", Latitude = 8.93716481344, Longitude = -74.0382545181 },
new Place { Code = "13670", IsoCode = "13670", Name = "SAN PABLO - BOLÍVAR", Latitude = 7.47747543628, Longitude = -73.9245578327 },
new Place { Code = "13673", IsoCode = "13673", Name = "SANTA CATALINA - BOLÍVAR", Latitude = 10.603266877, Longitude = -75.2903852668 },
new Place { Code = "13683", IsoCode = "13683", Name = "SANTA ROSA - BOLÍVAR", Latitude = 10.4454727189, Longitude = -75.3691024298 },
new Place { Code = "13688", IsoCode = "13688", Name = "SANTA ROSA DEL SUR - BOLÍVAR", Latitude = 7.96319110325, Longitude = -74.0514460679 },
new Place { Code = "13744", IsoCode = "13744", Name = "SIMITÍ - BOLÍVAR", Latitude = 7.95522013567, Longitude = -73.9463661068 },
new Place { Code = "13760", IsoCode = "13760", Name = "SOPLAVIENTO - BOLÍVAR", Latitude = 10.3894223653, Longitude = -75.1393732218 },
new Place { Code = "13780", IsoCode = "13780", Name = "TALAIGUA NUEVO - BOLÍVAR", Latitude = 9.30540280812, Longitude = -74.567911851 },
new Place { Code = "13810", IsoCode = "13810", Name = "TIQUISIO - BOLÍVAR", Latitude = 8.55646720528, Longitude = -74.264787715 },
new Place { Code = "13836", IsoCode = "13836", Name = "TURBACO - BOLÍVAR", Latitude = 10.3357902885, Longitude = -75.4155469089 },
new Place { Code = "13838", IsoCode = "13838", Name = "TURBANÁ - BOLÍVAR", Latitude = 10.2707782012, Longitude = -75.4443201111 },
new Place { Code = "13873", IsoCode = "13873", Name = "VILLANUEVA - BOLÍVAR", Latitude = 10.4444526308, Longitude = -75.2762219792 },
new Place { Code = "13894", IsoCode = "13894", Name = "ZAMBRANO - BOLÍVAR", Latitude = 9.75140245083, Longitude = -74.8258813861 },
new Place { Code = "15001", IsoCode = "15001", Name = "TUNJA - BOYACÁ", Latitude = 5.53937063584, Longitude = -73.3543638186 },
new Place { Code = "15022", IsoCode = "15022", Name = "ALMEIDA - BOYACÁ", Latitude = 4.97124101468, Longitude = -73.3787857955 },
new Place { Code = "15047", IsoCode = "15047", Name = "AQUITANIA - BOYACÁ", Latitude = 5.51831038891, Longitude = -72.8843505151 },
new Place { Code = "15051", IsoCode = "15051", Name = "ARCABUCO - BOYACÁ", Latitude = 5.75661447168, Longitude = -73.4396912192 },
new Place { Code = "15087", IsoCode = "15087", Name = "BELÉN - BOYACÁ", Latitude = 5.98833686523, Longitude = -72.9112545697 },
new Place { Code = "15090", IsoCode = "15090", Name = "BERBEO - BOYACÁ", Latitude = 5.2271520402, Longitude = -73.1268643511 },
new Place { Code = "15092", IsoCode = "15092", Name = "BETÉITIVA - BOYACÁ", Latitude = 5.91081053448, Longitude = -72.8089600105 },
new Place { Code = "15097", IsoCode = "15097", Name = "BOAVITA - BOYACÁ", Latitude = 6.33067803458, Longitude = -72.5847752243 },
new Place { Code = "15104", IsoCode = "15104", Name = "BOYACÁ - BOYACÁ", Latitude = 5.45455383227, Longitude = -73.3620268275 },
new Place { Code = "15106", IsoCode = "15106", Name = "BRICEÑO - BOYACÁ", Latitude = 5.69016431203, Longitude = -73.9233039987 },
new Place { Code = "15109", IsoCode = "15109", Name = "BUENAVISTA - BOYACÁ", Latitude = 5.51174852719, Longitude = -73.9409990293 },
new Place { Code = "15114", IsoCode = "15114", Name = "BUSBANZÁ - BOYACÁ", Latitude = 5.83037889421, Longitude = -72.8838834271 },
new Place { Code = "15131", IsoCode = "15131", Name = "CALDAS - BOYACÁ", Latitude = 5.55446875145, Longitude = -73.8653103464 },
new Place { Code = "15135", IsoCode = "15135", Name = "CAMPOHERMOSO - BOYACÁ", Latitude = 5.03063004868, Longitude = -73.1035182105 },
new Place { Code = "15162", IsoCode = "15162", Name = "CERINZA - BOYACÁ", Latitude = 5.955976752, Longitude = -72.9477205036 },
new Place { Code = "15172", IsoCode = "15172", Name = "CHINAVITA - BOYACÁ", Latitude = 5.16741662868, Longitude = -73.3686289379 },
new Place { Code = "15176", IsoCode = "15176", Name = "CHIQUINQUIRÁ - BOYACÁ", Latitude = 5.61485105697, Longitude = -73.8187107146 },
new Place { Code = "15180", IsoCode = "15180", Name = "CHISCAS - BOYACÁ", Latitude = 6.55349164254, Longitude = -72.5002931534 },
new Place { Code = "15183", IsoCode = "15183", Name = "CHITA - BOYACÁ", Latitude = 6.18742408063, Longitude = -72.4735580541 },
new Place { Code = "15185", IsoCode = "15185", Name = "CHITARAQUE - BOYACÁ", Latitude = 6.02747548905, Longitude = -73.4469293634 },
new Place { Code = "15187", IsoCode = "15187", Name = "CHIVATÁ - BOYACÁ", Latitude = 5.56040152608, Longitude = -73.2808946232 },
new Place { Code = "15189", IsoCode = "15189", Name = "CIÉNEGA - BOYACÁ", Latitude = 5.40952113356, Longitude = -73.2960896762 },
new Place { Code = "15204", IsoCode = "15204", Name = "CÓMBITA - BOYACÁ", Latitude = 5.634334216, Longitude = -73.3238423344 },
new Place { Code = "15212", IsoCode = "15212", Name = "COPER - BOYACÁ", Latitude = 5.4753923798, Longitude = -74.0450352906 },
new Place { Code = "15215", IsoCode = "15215", Name = "CORRALES - BOYACÁ", Latitude = 5.82808297937, Longitude = -72.8448075296 },
new Place { Code = "15218", IsoCode = "15218", Name = "COVARACHÍA - BOYACÁ", Latitude = 6.50027200205, Longitude = -72.7389949186 },
new Place { Code = "15223", IsoCode = "15223", Name = "CUBARÁ - BOYACÁ", Latitude = 7.00373327286, Longitude = -72.1060298045 },
new Place { Code = "15224", IsoCode = "15224", Name = "CUCAITA - BOYACÁ", Latitude = 5.54301842098, Longitude = -73.454200081 },
new Place { Code = "15226", IsoCode = "15226", Name = "CUÍTIVA - BOYACÁ", Latitude = 5.5802641113, Longitude = -72.9661286503 },
new Place { Code = "15232", IsoCode = "15232", Name = "CHÍQUIZA - BOYACÁ", Latitude = 5.60440241797, Longitude = -73.4857203286 },
new Place { Code = "15236", IsoCode = "15236", Name = "CHIVOR - BOYACÁ", Latitude = 4.88876763021, Longitude = -73.3698003698 },
new Place { Code = "15238", IsoCode = "15238", Name = "DUITAMA - BOYACÁ", Latitude = 5.81936914099, Longitude = -73.0302686329 },
new Place { Code = "15244", IsoCode = "15244", Name = "EL COCUY - BOYACÁ", Latitude = 6.41037802779, Longitude = -72.4454127648 },
new Place { Code = "15248", IsoCode = "15248", Name = "EL ESPINO - BOYACÁ", Latitude = 6.4826131397, Longitude = -72.4963221128 },
new Place { Code = "15272", IsoCode = "15272", Name = "FIRAVITOBA - BOYACÁ", Latitude = 5.66912083496, Longitude = -72.9937203959 },
new Place { Code = "15276", IsoCode = "15276", Name = "FLORESTA - BOYACÁ", Latitude = 5.85943916568, Longitude = -72.9190391027 },
new Place { Code = "15293", IsoCode = "15293", Name = "GACHANTIVÁ - BOYACÁ", Latitude = 5.75196804738, Longitude = -73.5493153358 },
new Place { Code = "15296", IsoCode = "15296", Name = "GÁMEZA - BOYACÁ", Latitude = 5.80283711498, Longitude = -72.8062102157 },
new Place { Code = "15299", IsoCode = "15299", Name = "GARAGOA - BOYACÁ", Latitude = 5.08228084885, Longitude = -73.3647669702 },
new Place { Code = "15317", IsoCode = "15317", Name = "GUACAMAYAS - BOYACÁ", Latitude = 6.45971197395, Longitude = -72.500600213 },
new Place { Code = "15322", IsoCode = "15322", Name = "GUATEQUE - BOYACÁ", Latitude = 5.00708724993, Longitude = -73.4722844817 },
new Place { Code = "15325", IsoCode = "15325", Name = "GUAYATÁ - BOYACÁ", Latitude = 4.96682008754, Longitude = -73.4901186533 },
new Place { Code = "15332", IsoCode = "15332", Name = "GÜICÁN DE LA SIERRA - BOYACÁ", Latitude = 6.46292958742, Longitude = -72.4120601319 },
new Place { Code = "15362", IsoCode = "15362", Name = "IZA - BOYACÁ", Latitude = 5.61235844867, Longitude = -72.9796484028 },
new Place { Code = "15367", IsoCode = "15367", Name = "JENESANO - BOYACÁ", Latitude = 5.38487936219, Longitude = -73.3639584567 },
new Place { Code = "15368", IsoCode = "15368", Name = "JERICÓ - BOYACÁ", Latitude = 6.14610490844, Longitude = -72.5719920111 },
new Place { Code = "15377", IsoCode = "15377", Name = "LABRANZAGRANDE - BOYACÁ", Latitude = 5.56235834208, Longitude = -72.5775941245 },
new Place { Code = "15380", IsoCode = "15380", Name = "LA CAPILLA - BOYACÁ", Latitude = 5.09555866963, Longitude = -73.445010629 },
new Place { Code = "15401", IsoCode = "15401", Name = "LA VICTORIA - BOYACÁ", Latitude = 5.52314917168, Longitude = -74.2345974039 },
new Place { Code = "15403", IsoCode = "15403", Name = "LA UVITA - BOYACÁ", Latitude = 6.31679484036, Longitude = -72.5594378649 },
new Place { Code = "15407", IsoCode = "15407", Name = "VILLA DE LEYVA - BOYACÁ", Latitude = 5.63623795957, Longitude = -73.5264455074 },
new Place { Code = "15425", IsoCode = "15425", Name = "MACANAL - BOYACÁ", Latitude = 4.97221733095, Longitude = -73.319521182 },
new Place { Code = "15442", IsoCode = "15442", Name = "MARIPÍ - BOYACÁ", Latitude = 5.54929277249, Longitude = -74.0046488073 },
new Place { Code = "15455", IsoCode = "15455", Name = "MIRAFLORES - BOYACÁ", Latitude = 5.19594580009, Longitude = -73.14486261 },
new Place { Code = "15464", IsoCode = "15464", Name = "MONGUA - BOYACÁ", Latitude = 5.75283042742, Longitude = -72.8002051309 },
new Place { Code = "15466", IsoCode = "15466", Name = "MONGUÍ - BOYACÁ", Latitude = 5.72336164372, Longitude = -72.8488798848 },
new Place { Code = "15469", IsoCode = "15469", Name = "MONIQUIRÁ - BOYACÁ", Latitude = 5.87376486789, Longitude = -73.5741080327 },
new Place { Code = "15476", IsoCode = "15476", Name = "MOTAVITA - BOYACÁ", Latitude = 5.57754426501, Longitude = -73.3681498024 },
new Place { Code = "15480", IsoCode = "15480", Name = "MUZO - BOYACÁ", Latitude = 5.53127931395, Longitude = -74.1030009907 },
new Place { Code = "15491", IsoCode = "15491", Name = "NOBSA - BOYACÁ", Latitude = 5.77057113804, Longitude = -72.9402607274 },
new Place { Code = "15494", IsoCode = "15494", Name = "NUEVO COLÓN - BOYACÁ", Latitude = 5.35506695617, Longitude = -73.4570665385 },
new Place { Code = "15500", IsoCode = "15500", Name = "OICATÁ - BOYACÁ", Latitude = 5.59440917568, Longitude = -73.3077536803 },
new Place { Code = "15507", IsoCode = "15507", Name = "OTANCHE - BOYACÁ", Latitude = 5.65799269911, Longitude = -74.1813101815 },
new Place { Code = "15511", IsoCode = "15511", Name = "PACHAVITA - BOYACÁ", Latitude = 5.14022874452, Longitude = -73.3971076544 },
new Place { Code = "15514", IsoCode = "15514", Name = "PÁEZ - BOYACÁ", Latitude = 5.10066041399, Longitude = -73.052000572 },
new Place { Code = "15516", IsoCode = "15516", Name = "PAIPA - BOYACÁ", Latitude = 5.78048910058, Longitude = -73.1167437822 },
new Place { Code = "15518", IsoCode = "15518", Name = "PAJARITO - BOYACÁ", Latitude = 5.29380067178, Longitude = -72.7025663298 },
new Place { Code = "15522", IsoCode = "15522", Name = "PANQUEBA - BOYACÁ", Latitude = 6.44256891347, Longitude = -72.4589391962 },
new Place { Code = "15531", IsoCode = "15531", Name = "PAUNA - BOYACÁ", Latitude = 5.65653655177, Longitude = -73.9785815826 },
new Place { Code = "15533", IsoCode = "15533", Name = "PAYA - BOYACÁ", Latitude = 5.6263952138, Longitude = -72.4223160798 },
new Place { Code = "15537", IsoCode = "15537", Name = "PAZ DE RÍO - BOYACÁ", Latitude = 5.98807090613, Longitude = -72.7475252291 },
new Place { Code = "15542", IsoCode = "15542", Name = "PESCA - BOYACÁ", Latitude = 5.55868752792, Longitude = -73.050663428 },
new Place { Code = "15550", IsoCode = "15550", Name = "PISBA - BOYACÁ", Latitude = 5.72305842393, Longitude = -72.4831827809 },
new Place { Code = "15572", IsoCode = "15572", Name = "PUERTO BOYACÁ - BOYACÁ", Latitude = 5.97331379456, Longitude = -74.5750541387 },
new Place { Code = "15580", IsoCode = "15580", Name = "QUÍPAMA - BOYACÁ", Latitude = 5.52344696291, Longitude = -74.179166914 },
new Place { Code = "15599", IsoCode = "15599", Name = "RAMIRIQUÍ - BOYACÁ", Latitude = 5.40117777129, Longitude = -73.3354655533 },
new Place { Code = "15600", IsoCode = "15600", Name = "RÁQUIRA - BOYACÁ", Latitude = 5.53873793625, Longitude = -73.6322885637 },
new Place { Code = "15621", IsoCode = "15621", Name = "RONDÓN - BOYACÁ", Latitude = 5.35703603852, Longitude = -73.2085952061 },
new Place { Code = "15632", IsoCode = "15632", Name = "SABOYÁ - BOYACÁ", Latitude = 5.69689929346, Longitude = -73.7629174335 },
new Place { Code = "15638", IsoCode = "15638", Name = "SÁCHICA - BOYACÁ", Latitude = 5.58303012051, Longitude = -73.5425258614 },
new Place { Code = "15646", IsoCode = "15646", Name = "SAMACÁ - BOYACÁ", Latitude = 5.49262740357, Longitude = -73.4859714562 },
new Place { Code = "15660", IsoCode = "15660", Name = "SAN EDUARDO - BOYACÁ", Latitude = 5.22420661716, Longitude = -73.0766026379 },
new Place { Code = "15664", IsoCode = "15664", Name = "SAN JOSÉ DE PARE - BOYACÁ", Latitude = 6.01961048939, Longitude = -73.5434490918 },
new Place { Code = "15667", IsoCode = "15667", Name = "SAN LUIS DE GACENO - BOYACÁ", Latitude = 4.81870508097, Longitude = -73.1688722705 },
new Place { Code = "15673", IsoCode = "15673", Name = "SAN MATEO - BOYACÁ", Latitude = 6.40183421353, Longitude = -72.5549428659 },
new Place { Code = "15676", IsoCode = "15676", Name = "SAN MIGUEL DE SEMA - BOYACÁ", Latitude = 5.51772942922, Longitude = -73.7219924849 },
new Place { Code = "15681", IsoCode = "15681", Name = "SAN PABLO DE BORBUR - BOYACÁ", Latitude = 5.65901775706, Longitude = -74.0665923317 },
new Place { Code = "15686", IsoCode = "15686", Name = "SANTANA - BOYACÁ", Latitude = 6.0575699273, Longitude = -73.4818524572 },
new Place { Code = "15690", IsoCode = "15690", Name = "SANTA MARÍA - BOYACÁ", Latitude = 4.85760064062, Longitude = -73.2632587622 },
new Place { Code = "15693", IsoCode = "15693", Name = "SANTA ROSA DE VITERBO - BOYACÁ", Latitude = 5.87473860404, Longitude = -72.9823863595 },
new Place { Code = "15696", IsoCode = "15696", Name = "SANTA SOFÍA - BOYACÁ", Latitude = 5.71227372283, Longitude = -73.604182036 },
new Place { Code = "15720", IsoCode = "15720", Name = "SATIVANORTE - BOYACÁ", Latitude = 6.13152095194, Longitude = -72.7078717765 },
new Place { Code = "15723", IsoCode = "15723", Name = "SATIVASUR - BOYACÁ", Latitude = 6.093234404, Longitude = -72.7120698536 },
new Place { Code = "15740", IsoCode = "15740", Name = "SIACHOQUE - BOYACÁ", Latitude = 5.51101900101, Longitude = -73.2451885941 },
new Place { Code = "15753", IsoCode = "15753", Name = "SOATÁ - BOYACÁ", Latitude = 6.33365418585, Longitude = -72.6833174046 },
new Place { Code = "15755", IsoCode = "15755", Name = "SOCOTÁ - BOYACÁ", Latitude = 6.04117539594, Longitude = -72.6364603722 },
new Place { Code = "15757", IsoCode = "15757", Name = "SOCHA - BOYACÁ", Latitude = 5.99685874976, Longitude = -72.6916265433 },
new Place { Code = "15759", IsoCode = "15759", Name = "SOGAMOSO - BOYACÁ", Latitude = 5.72486205266, Longitude = -72.923236899 },
new Place { Code = "15761", IsoCode = "15761", Name = "SOMONDOCO - BOYACÁ", Latitude = 4.98580939218, Longitude = -73.4333122291 },
new Place { Code = "15762", IsoCode = "15762", Name = "SORA - BOYACÁ", Latitude = 5.56685654075, Longitude = -73.4498672629 },
new Place { Code = "15763", IsoCode = "15763", Name = "SOTAQUIRÁ - BOYACÁ", Latitude = 5.76516635173, Longitude = -73.2472261796 },
new Place { Code = "15764", IsoCode = "15764", Name = "SORACÁ - BOYACÁ", Latitude = 5.50108431683, Longitude = -73.3328154953 },
new Place { Code = "15774", IsoCode = "15774", Name = "SUSACÓN - BOYACÁ", Latitude = 6.2307747366, Longitude = -72.6897880303 },
new Place { Code = "15776", IsoCode = "15776", Name = "SUTAMARCHÁN - BOYACÁ", Latitude = 5.62014390877, Longitude = -73.6205637062 },
new Place { Code = "15778", IsoCode = "15778", Name = "SUTATENZA - BOYACÁ", Latitude = 5.02324263103, Longitude = -73.4520467214 },
new Place { Code = "15790", IsoCode = "15790", Name = "TASCO - BOYACÁ", Latitude = 5.90898896374, Longitude = -72.7823725547 },
new Place { Code = "15798", IsoCode = "15798", Name = "TENZA - BOYACÁ", Latitude = 5.0768315662, Longitude = -73.4216511523 },
new Place { Code = "15804", IsoCode = "15804", Name = "TIBANÁ - BOYACÁ", Latitude = 5.31618446526, Longitude = -73.3967445026 },
new Place { Code = "15806", IsoCode = "15806", Name = "TIBASOSA - BOYACÁ", Latitude = 5.74715414319, Longitude = -72.9996464966 },
new Place { Code = "15808", IsoCode = "15808", Name = "TINJACÁ - BOYACÁ", Latitude = 5.57901932907, Longitude = -73.6471490956 },
new Place { Code = "15810", IsoCode = "15810", Name = "TIPACOQUE - BOYACÁ", Latitude = 6.41502583025, Longitude = -72.6901923301 },
new Place { Code = "15814", IsoCode = "15814", Name = "TOCA - BOYACÁ", Latitude = 5.56541863786, Longitude = -73.1845174634 },
new Place { Code = "15816", IsoCode = "15816", Name = "TOGÜÍ - BOYACÁ", Latitude = 5.93754576969, Longitude = -73.5135719162 },
new Place { Code = "15820", IsoCode = "15820", Name = "TÓPAGA - BOYACÁ", Latitude = 5.76927431898, Longitude = -72.8333505555 },
new Place { Code = "15822", IsoCode = "15822", Name = "TOTA - BOYACÁ", Latitude = 5.56087990488, Longitude = -72.9854281572 },
new Place { Code = "15832", IsoCode = "15832", Name = "TUNUNGUÁ - BOYACÁ", Latitude = 5.73040797901, Longitude = -73.9330350622 },
new Place { Code = "15835", IsoCode = "15835", Name = "TURMEQUÉ - BOYACÁ", Latitude = 5.32384575013, Longitude = -73.4885656969 },
new Place { Code = "15837", IsoCode = "15837", Name = "TUTA - BOYACÁ", Latitude = 5.69072807998, Longitude = -73.2258853682 },
new Place { Code = "15839", IsoCode = "15839", Name = "TUTAZÁ - BOYACÁ", Latitude = 6.03194217187, Longitude = -72.8572505571 },
new Place { Code = "15842", IsoCode = "15842", Name = "ÚMBITA - BOYACÁ", Latitude = 5.21775307518, Longitude = -73.4574526682 },
new Place { Code = "15861", IsoCode = "15861", Name = "VENTAQUEMADA - BOYACÁ", Latitude = 5.36925188265, Longitude = -73.5206324064 },
new Place { Code = "15879", IsoCode = "15879", Name = "VIRACACHÁ - BOYACÁ", Latitude = 5.43670756257, Longitude = -73.2966647004 },
new Place { Code = "15897", IsoCode = "15897", Name = "ZETAQUIRA - BOYACÁ", Latitude = 5.28434656469, Longitude = -73.1720299685 },
new Place { Code = "17001", IsoCode = "17001", Name = "MANIZALES - CALDAS", Latitude = 5.05705056379, Longitude = -75.4904150625 },
new Place { Code = "17013", IsoCode = "17013", Name = "AGUADAS - CALDAS", Latitude = 5.6126036828, Longitude = -75.455726565 },
new Place { Code = "17042", IsoCode = "17042", Name = "ANSERMA - CALDAS", Latitude = 5.23807382965, Longitude = -75.7839965823 },
new Place { Code = "17050", IsoCode = "17050", Name = "ARANZAZU - CALDAS", Latitude = 5.27130438493, Longitude = -75.4907773111 },
new Place { Code = "17088", IsoCode = "17088", Name = "BELALCÁZAR - CALDAS", Latitude = 4.99517768145, Longitude = -75.8038072984 },
new Place { Code = "17174", IsoCode = "17174", Name = "CHINCHINÁ - CALDAS", Latitude = 4.98551800459, Longitude = -75.6063849663 },
new Place { Code = "17272", IsoCode = "17272", Name = "FILADELFIA - CALDAS", Latitude = 5.29735027786, Longitude = -75.562282237 },
new Place { Code = "17380", IsoCode = "17380", Name = "LA DORADA - CALDAS", Latitude = 5.44389999408, Longitude = -74.6744521523 },
new Place { Code = "17388", IsoCode = "17388", Name = "LA MERCED - CALDAS", Latitude = 5.39480455966, Longitude = -75.5473481633 },
new Place { Code = "17433", IsoCode = "17433", Name = "MANZANARES - CALDAS", Latitude = 5.25410160582, Longitude = -75.1535019918 },
new Place { Code = "17442", IsoCode = "17442", Name = "MARMATO - CALDAS", Latitude = 5.47433367144, Longitude = -75.5996904188 },
new Place { Code = "17444", IsoCode = "17444", Name = "MARQUETALIA - CALDAS", Latitude = 5.29865089582, Longitude = -75.0478539726 },
new Place { Code = "17446", IsoCode = "17446", Name = "MARULANDA - CALDAS", Latitude = 5.2835107602, Longitude = -75.258325325 },
new Place { Code = "17486", IsoCode = "17486", Name = "NEIRA - CALDAS", Latitude = 5.16641593633, Longitude = -75.5197693228 },
new Place { Code = "17495", IsoCode = "17495", Name = "NORCASIA - CALDAS", Latitude = 5.575276372, Longitude = -74.8891796242 },
new Place { Code = "17513", IsoCode = "17513", Name = "PÁCORA - CALDAS", Latitude = 5.52868689559, Longitude = -75.4600089101 },
new Place { Code = "17524", IsoCode = "17524", Name = "PALESTINA - CALDAS", Latitude = 5.0191163439, Longitude = -75.6211133951 },
new Place { Code = "17541", IsoCode = "17541", Name = "PENSILVANIA - CALDAS", Latitude = 5.38371851682, Longitude = -75.159294496 },
new Place { Code = "17614", IsoCode = "17614", Name = "RIOSUCIO - CALDAS", Latitude = 5.42395347461, Longitude = -75.7023188489 },
new Place { Code = "17616", IsoCode = "17616", Name = "RISARALDA - CALDAS", Latitude = 5.15940031424, Longitude = -75.7706314648 },
new Place { Code = "17653", IsoCode = "17653", Name = "SALAMINA - CALDAS", Latitude = 5.4026014886, Longitude = -75.4871709558 },
new Place { Code = "17662", IsoCode = "17662", Name = "SAMANÁ - CALDAS", Latitude = 5.41307433334, Longitude = -74.9923802605 },
new Place { Code = "17665", IsoCode = "17665", Name = "SAN JOSÉ - CALDAS", Latitude = 5.08264286212, Longitude = -75.7916509882 },
new Place { Code = "17777", IsoCode = "17777", Name = "SUPÍA - CALDAS", Latitude = 5.44609993376, Longitude = -75.649466209 },
new Place { Code = "17867", IsoCode = "17867", Name = "VICTORIA - CALDAS", Latitude = 5.31706445035, Longitude = -74.9106926322 },
new Place { Code = "17873", IsoCode = "17873", Name = "VILLAMARÍA - CALDAS", Latitude = 5.03916965231, Longitude = -75.4898102931 },
new Place { Code = "17877", IsoCode = "17877", Name = "VITERBO - CALDAS", Latitude = 5.06286441938, Longitude = -75.8707592879 },
new Place { Code = "18001", IsoCode = "18001", Name = "FLORENCIA - CAQUETÁ", Latitude = 1.61582907928, Longitude = -75.6079932658 },
new Place { Code = "18029", IsoCode = "18029", Name = "ALBANIA - CAQUETÁ", Latitude = 1.32903377181, Longitude = -75.8786522147 },
new Place { Code = "18094", IsoCode = "18094", Name = "BELÉN DE LOS ANDAQUÍES - CAQUETÁ", Latitude = 1.41997507453, Longitude = -75.8692688364 },
new Place { Code = "18150", IsoCode = "18150", Name = "CARTAGENA DEL CHAIRÁ - CAQUETÁ", Latitude = 1.3340194073, Longitude = -74.8475720157 },
new Place { Code = "18205", IsoCode = "18205", Name = "CURILLO - CAQUETÁ", Latitude = 1.03365529502, Longitude = -75.9203547685 },
new Place { Code = "18247", IsoCode = "18247", Name = "EL DONCELLO - CAQUETÁ", Latitude = 1.67906350715, Longitude = -75.2828373662 },
new Place { Code = "18256", IsoCode = "18256", Name = "EL PAUJÍL - CAQUETÁ", Latitude = 1.57049113684, Longitude = -75.3267456512 },
new Place { Code = "18410", IsoCode = "18410", Name = "LA MONTAÑITA - CAQUETÁ", Latitude = 1.48833022079, Longitude = -75.4361470337 },
new Place { Code = "18460", IsoCode = "18460", Name = "MILÁN - CAQUETÁ", Latitude = 1.29064424048, Longitude = -75.507530311 },
new Place { Code = "18479", IsoCode = "18479", Name = "MORELIA - CAQUETÁ", Latitude = 1.48803902537, Longitude = -75.7265584717 },
new Place { Code = "18592", IsoCode = "18592", Name = "PUERTO RICO - CAQUETÁ", Latitude = 1.91091861998, Longitude = -75.1580393577 },
new Place { Code = "18610", IsoCode = "18610", Name = "SAN JOSÉ DEL FRAGUA - CAQUETÁ", Latitude = 1.33172583849, Longitude = -75.9736618541 },
new Place { Code = "18753", IsoCode = "18753", Name = "SAN VICENTE DEL CAGUÁN - CAQUETÁ", Latitude = 2.11341773833, Longitude = -74.7719596917 },
new Place { Code = "18756", IsoCode = "18756", Name = "SOLANO - CAQUETÁ", Latitude = 0.699015532578, Longitude = -75.2535860759 },
new Place { Code = "18785", IsoCode = "18785", Name = "SOLITA - CAQUETÁ", Latitude = 0.872650020368, Longitude = -75.6199809569 },
new Place { Code = "18860", IsoCode = "18860", Name = "VALPARAÍSO - CAQUETÁ", Latitude = 1.19761525166, Longitude = -75.7053662852 },
new Place { Code = "19001", IsoCode = "19001", Name = "POPAYÁN - CAUCA", Latitude = 2.44823960489, Longitude = -76.624787641 },
new Place { Code = "19022", IsoCode = "19022", Name = "ALMAGUER - CAUCA", Latitude = 1.91525377527, Longitude = -76.8528174101 },
new Place { Code = "19050", IsoCode = "19050", Name = "ARGELIA - CAUCA", Latitude = 2.25554956676, Longitude = -77.2490752264 },
new Place { Code = "19075", IsoCode = "19075", Name = "BALBOA - CAUCA", Latitude = 2.04139355858, Longitude = -77.2165412103 },
new Place { Code = "19100", IsoCode = "19100", Name = "BOLÍVAR - CAUCA", Latitude = 1.83756270293, Longitude = -76.9667571992 },
new Place { Code = "19110", IsoCode = "19110", Name = "BUENOS AIRES - CAUCA", Latitude = 3.01602440527, Longitude = -76.6425464034 },
new Place { Code = "19130", IsoCode = "19130", Name = "CAJIBÍO - CAUCA", Latitude = 2.62303108857, Longitude = -76.570385642 },
new Place { Code = "19137", IsoCode = "19137", Name = "CALDONO - CAUCA", Latitude = 2.79750888116, Longitude = -76.4847018162 },
new Place { Code = "19142", IsoCode = "19142", Name = "CALOTO - CAUCA", Latitude = 3.03315836268, Longitude = -76.408484604 },
new Place { Code = "19212", IsoCode = "19212", Name = "CORINTO - CAUCA", Latitude = 3.17565160975, Longitude = -76.2616272807 },
new Place { Code = "19256", IsoCode = "19256", Name = "EL TAMBO - CAUCA", Latitude = 2.45242884926, Longitude = -76.8114006188 },
new Place { Code = "19290", IsoCode = "19290", Name = "FLORENCIA - CAUCA", Latitude = 1.68303539793, Longitude = -77.0727537602 },
new Place { Code = "19300", IsoCode = "19300", Name = "GUACHENÉ - CAUCA", Latitude = 3.13363641726, Longitude = -76.3960623061 },
new Place { Code = "19318", IsoCode = "19318", Name = "GUAPÍ - CAUCA", Latitude = 2.57198998096, Longitude = -77.8854667538 },
new Place { Code = "19355", IsoCode = "19355", Name = "INZÁ - CAUCA", Latitude = 2.54873811501, Longitude = -76.0639665737 },
new Place { Code = "19364", IsoCode = "19364", Name = "JAMBALÓ - CAUCA", Latitude = 2.77802100734, Longitude = -76.3244074327 },
new Place { Code = "19392", IsoCode = "19392", Name = "LA SIERRA - CAUCA", Latitude = 2.17704168214, Longitude = -76.7632022599 },
new Place { Code = "19397", IsoCode = "19397", Name = "LA VEGA - CAUCA", Latitude = 2.00463839075, Longitude = -76.7815037392 },
new Place { Code = "19418", IsoCode = "19418", Name = "LÓPEZ DE MICAY - CAUCA", Latitude = 2.84591662511, Longitude = -77.2482770971 },
new Place { Code = "19450", IsoCode = "19450", Name = "MERCADERES - CAUCA", Latitude = 1.80307505355, Longitude = -77.1687293641 },
new Place { Code = "19455", IsoCode = "19455", Name = "MIRANDA - CAUCA", Latitude = 3.25189406596, Longitude = -76.229670428 },
new Place { Code = "19473", IsoCode = "19473", Name = "MORALES - CAUCA", Latitude = 2.74930602502, Longitude = -76.6255849081 },
new Place { Code = "19513", IsoCode = "19513", Name = "PADILLA - CAUCA", Latitude = 3.22299731562, Longitude = -76.3130175883 },
new Place { Code = "19517", IsoCode = "19517", Name = "PÁEZ - CAUCA", Latitude = 2.64531146532, Longitude = -75.9719235642 },
new Place { Code = "19532", IsoCode = "19532", Name = "PATÍA - CAUCA", Latitude = 2.11308139068, Longitude = -76.9856818172 },
new Place { Code = "19533", IsoCode = "19533", Name = "PIAMONTE - CAUCA", Latitude = 1.11567690787, Longitude = -76.3267213883 },
new Place { Code = "19548", IsoCode = "19548", Name = "PIENDAMÓ - CAUCA", Latitude = 2.63758943296, Longitude = -76.5273955374 },
new Place { Code = "19573", IsoCode = "19573", Name = "PUERTO TEJADA - CAUCA", Latitude = 3.23265929318, Longitude = -76.4170683658 },
new Place { Code = "19585", IsoCode = "19585", Name = "PURACÉ - CAUCA", Latitude = 2.34259523424, Longitude = -76.4969180467 },
new Place { Code = "19622", IsoCode = "19622", Name = "ROSAS - CAUCA", Latitude = 2.26172005206, Longitude = -76.7388799668 },
new Place { Code = "19693", IsoCode = "19693", Name = "SAN SEBASTIÁN - CAUCA", Latitude = 1.83850066649, Longitude = -76.7687767065 },
new Place { Code = "19698", IsoCode = "19698", Name = "SANTANDER DE QUILICHAO - CAUCA", Latitude = 3.01128796768, Longitude = -76.4853458905 },
new Place { Code = "19701", IsoCode = "19701", Name = "SANTA ROSA - CAUCA", Latitude = 1.70302519951, Longitude = -76.5738234216 },
new Place { Code = "19743", IsoCode = "19743", Name = "SILVIA - CAUCA", Latitude = 2.61512301644, Longitude = -76.3727784185 },
new Place { Code = "19760", IsoCode = "19760", Name = "SOTARA - CAUCA", Latitude = 2.25321720309, Longitude = -76.6141709676 },
new Place { Code = "19780", IsoCode = "19780", Name = "SUÁREZ - CAUCA", Latitude = 2.95488168766, Longitude = -76.695829783 },
new Place { Code = "19785", IsoCode = "19785", Name = "SUCRE - CAUCA", Latitude = 2.03811060637, Longitude = -76.9255077941 },
new Place { Code = "19807", IsoCode = "19807", Name = "TIMBÍO - CAUCA", Latitude = 2.34972061446, Longitude = -76.6778696915 },
new Place { Code = "19809", IsoCode = "19809", Name = "TIMBIQUÍ - CAUCA", Latitude = 2.7803566175, Longitude = -77.6706359847 },
new Place { Code = "19821", IsoCode = "19821", Name = "TORIBÍO - CAUCA", Latitude = 2.95370196906, Longitude = -76.2704930209 },
new Place { Code = "19824", IsoCode = "19824", Name = "TOTORÓ - CAUCA", Latitude = 2.51119762737, Longitude = -76.3981705509 },
new Place { Code = "19845", IsoCode = "19845", Name = "VILLA RICA - CAUCA", Latitude = 3.17492271254, Longitude = -76.4616137142 },
new Place { Code = "20001", IsoCode = "20001", Name = "VALLEDUPAR - CESAR", Latitude = 10.4615184337, Longitude = -73.2586483431 },
new Place { Code = "20011", IsoCode = "20011", Name = "AGUACHICA - CESAR", Latitude = 8.31012096929, Longitude = -73.6013004495 },
new Place { Code = "20013", IsoCode = "20013", Name = "AGUSTÍN CODAZZI - CESAR", Latitude = 10.0403645547, Longitude = -73.2374314486 },
new Place { Code = "20032", IsoCode = "20032", Name = "ASTREA - CESAR", Latitude = 9.49533435313, Longitude = -73.9753900254 },
new Place { Code = "20045", IsoCode = "20045", Name = "BECERRIL - CESAR", Latitude = 9.70413367081, Longitude = -73.2781073363 },
new Place { Code = "20060", IsoCode = "20060", Name = "BOSCONIA - CESAR", Latitude = 9.97437199423, Longitude = -73.888041926 },
new Place { Code = "20175", IsoCode = "20175", Name = "CHIMICHAGUA - CESAR", Latitude = 9.25788108195, Longitude = -73.8130833029 },
new Place { Code = "20178", IsoCode = "20178", Name = "CHIRIGUANÁ - CESAR", Latitude = 9.36137942001, Longitude = -73.6009132147 },
new Place { Code = "20228", IsoCode = "20228", Name = "CURUMANÍ - CESAR", Latitude = 9.2003397841, Longitude = -73.5413642738 },
new Place { Code = "20238", IsoCode = "20238", Name = "EL COPEY - CESAR", Latitude = 10.1491321093, Longitude = -73.9613702508 },
new Place { Code = "20250", IsoCode = "20250", Name = "EL PASO - CESAR", Latitude = 9.66187835651, Longitude = -73.7464543128 },
new Place { Code = "20295", IsoCode = "20295", Name = "GAMARRA - CESAR", Latitude = 8.32160639331, Longitude = -73.7425300764 },
new Place { Code = "20310", IsoCode = "20310", Name = "GONZÁLEZ - CESAR", Latitude = 8.39128097919, Longitude = -73.382089596 },
new Place { Code = "20383", IsoCode = "20383", Name = "LA GLORIA - CESAR", Latitude = 8.61801512913, Longitude = -73.8011114104 },
new Place { Code = "20400", IsoCode = "20400", Name = "LA JAGUA DE IBIRICO - CESAR", Latitude = 9.56286705626, Longitude = -73.3355518107 },
new Place { Code = "20443", IsoCode = "20443", Name = "MANAURE BALCÓN DEL CESAR - CESAR", Latitude = 10.3907483154, Longitude = -73.028834101 },
new Place { Code = "20517", IsoCode = "20517", Name = "PAILITAS - CESAR", Latitude = 8.95604299452, Longitude = -73.6253987915 },
new Place { Code = "20550", IsoCode = "20550", Name = "PELAYA - CESAR", Latitude = 8.68732471865, Longitude = -73.661830633 },
new Place { Code = "20570", IsoCode = "20570", Name = "PUEBLO BELLO - CESAR", Latitude = 10.4149687931, Longitude = -73.5870059442 },
new Place { Code = "20614", IsoCode = "20614", Name = "RÍO DE ORO - CESAR", Latitude = 8.29205395597, Longitude = -73.3870705262 },
new Place { Code = "20621", IsoCode = "20621", Name = "LA PAZ - CESAR", Latitude = 10.3864677933, Longitude = -73.1726913052 },
new Place { Code = "20710", IsoCode = "20710", Name = "SAN ALBERTO - CESAR", Latitude = 7.75620518383, Longitude = -73.3974595744 },
new Place { Code = "20750", IsoCode = "20750", Name = "SAN DIEGO - CESAR", Latitude = 10.3336927783, Longitude = -73.1807287956 },
new Place { Code = "20770", IsoCode = "20770", Name = "SAN MARTÍN - CESAR", Latitude = 8.00348637253, Longitude = -73.5127365857 },
new Place { Code = "20787", IsoCode = "20787", Name = "TAMALAMEQUE - CESAR", Latitude = 8.86239230038, Longitude = -73.8118501694 },
new Place { Code = "23001", IsoCode = "23001", Name = "MONTERÍA - CÓRDOBA", Latitude = 8.74991666326, Longitude = -75.8956393314 },
new Place { Code = "23068", IsoCode = "23068", Name = "AYAPEL - CÓRDOBA", Latitude = 8.31113196142, Longitude = -75.1470116379 },
new Place { Code = "23079", IsoCode = "23079", Name = "BUENAVISTA - CÓRDOBA", Latitude = 8.22219355708, Longitude = -75.479687687 },
new Place { Code = "23090", IsoCode = "23090", Name = "CANALETE - CÓRDOBA", Latitude = 8.78760091745, Longitude = -76.2407532604 },
new Place { Code = "23162", IsoCode = "23162", Name = "CERETÉ - CÓRDOBA", Latitude = 8.88666155327, Longitude = -75.7918818626 },
new Place { Code = "23168", IsoCode = "23168", Name = "CHIMÁ - CÓRDOBA", Latitude = 9.14934447081, Longitude = -75.6273818148 },
new Place { Code = "23182", IsoCode = "23182", Name = "CHINÚ - CÓRDOBA", Latitude = 9.10415277266, Longitude = -75.4016749242 },
new Place { Code = "23189", IsoCode = "23189", Name = "CIÉNAGA DE ORO - CÓRDOBA", Latitude = 8.87817659518, Longitude = -75.6221093386 },
new Place { Code = "23300", IsoCode = "23300", Name = "COTORRA - CÓRDOBA", Latitude = 9.04026968268, Longitude = -75.7855680706 },
new Place { Code = "23350", IsoCode = "23350", Name = "LA APARTADA - CÓRDOBA", Latitude = 8.04435931304, Longitude = -75.3338152962 },
new Place { Code = "23417", IsoCode = "23417", Name = "LORICA - CÓRDOBA", Latitude = 9.24036809981, Longitude = -75.8168895444 },
new Place { Code = "23419", IsoCode = "23419", Name = "LOS CÓRDOBAS - CÓRDOBA", Latitude = 8.89510878077, Longitude = -76.354709992 },
new Place { Code = "23464", IsoCode = "23464", Name = "MOMIL - CÓRDOBA", Latitude = 9.24002156913, Longitude = -75.6766729838 },
new Place { Code = "23466", IsoCode = "23466", Name = "MONTELÍBANO - CÓRDOBA", Latitude = 7.98570061466, Longitude = -75.4088497209 },
new Place { Code = "23500", IsoCode = "23500", Name = "MOÑITOS - CÓRDOBA", Latitude = 9.24470996414, Longitude = -76.134916122 },
new Place { Code = "23555", IsoCode = "23555", Name = "PLANETA RICA - CÓRDOBA", Latitude = 8.41130405874, Longitude = -75.584021495 },
new Place { Code = "23570", IsoCode = "23570", Name = "PUEBLO NUEVO - CÓRDOBA", Latitude = 8.50265564367, Longitude = -75.508177552 },
new Place { Code = "23574", IsoCode = "23574", Name = "PUERTO ESCONDIDO - CÓRDOBA", Latitude = 9.00219120432, Longitude = -76.2614747184 },
new Place { Code = "23580", IsoCode = "23580", Name = "PUERTO LIBERTADOR - CÓRDOBA", Latitude = 7.88927921391, Longitude = -75.6720222869 },
new Place { Code = "23586", IsoCode = "23586", Name = "PURÍSIMA DE LA CONCEPCIÓN - CÓRDOBA", Latitude = 9.23854883822, Longitude = -75.7232045562 },
new Place { Code = "23660", IsoCode = "23660", Name = "SAHAGÚN - CÓRDOBA", Latitude = 8.94250255224, Longitude = -75.436794027 },
new Place { Code = "23670", IsoCode = "23670", Name = "SAN ANDRÉS DE SOTAVENTO - CÓRDOBA", Latitude = 9.14488624683, Longitude = -75.5086994626 },
new Place { Code = "23672", IsoCode = "23672", Name = "SAN ANTERO - CÓRDOBA", Latitude = 9.3709325454, Longitude = -75.762201967 },
new Place { Code = "23675", IsoCode = "23675", Name = "SAN BERNARDO DEL VIENTO - CÓRDOBA", Latitude = 9.35387799342, Longitude = -75.9540444905 },
new Place { Code = "23678", IsoCode = "23678", Name = "SAN CARLOS - CÓRDOBA", Latitude = 8.79921910631, Longitude = -75.6990287551 },
new Place { Code = "23682", IsoCode = "23682", Name = "SAN JOSÉ DE URÉ - CÓRDOBA", Latitude = 7.78698363943, Longitude = -75.534854989 },
new Place { Code = "23686", IsoCode = "23686", Name = "SAN PELAYO - CÓRDOBA", Latitude = 8.95261525797, Longitude = -75.8322173185 },
new Place { Code = "23807", IsoCode = "23807", Name = "TIERRALTA - CÓRDOBA", Latitude = 8.17224654795, Longitude = -76.0623166279 },
new Place { Code = "23815", IsoCode = "23815", Name = "TUCHÍN - CÓRDOBA", Latitude = 9.18691768897, Longitude = -75.5526583031 },
new Place { Code = "23855", IsoCode = "23855", Name = "VALENCIA - CÓRDOBA", Latitude = 8.25735182413, Longitude = -76.1479385246 },
new Place { Code = "25001", IsoCode = "25001", Name = "AGUA DE DIOS - CUNDINAMARCA", Latitude = 4.37585313348, Longitude = -74.6695456055 },
new Place { Code = "25019", IsoCode = "25019", Name = "ALBÁN - CUNDINAMARCA", Latitude = 4.87608226929, Longitude = -74.4366988598 },
new Place { Code = "25035", IsoCode = "25035", Name = "ANAPOIMA - CUNDINAMARCA", Latitude = 4.56299758972, Longitude = -74.5306692069 },
new Place { Code = "25040", IsoCode = "25040", Name = "ANOLAIMA - CUNDINAMARCA", Latitude = 4.76166116785, Longitude = -74.4637806503 },
new Place { Code = "25053", IsoCode = "25053", Name = "ARBELÁEZ - CUNDINAMARCA", Latitude = 4.27225989155, Longitude = -74.4160840125 },
new Place { Code = "25086", IsoCode = "25086", Name = "BELTRÁN - CUNDINAMARCA", Latitude = 4.80268769976, Longitude = -74.7412351204 },
new Place { Code = "25095", IsoCode = "25095", Name = "BITUIMA - CUNDINAMARCA", Latitude = 4.87203567751, Longitude = -74.5396970208 },
new Place { Code = "25099", IsoCode = "25099", Name = "BOJACÁ - CUNDINAMARCA", Latitude = 4.74148625686, Longitude = -74.3475631168 },
new Place { Code = "25120", IsoCode = "25120", Name = "CABRERA - CUNDINAMARCA", Latitude = 3.98482848051, Longitude = -74.4842837632 },
new Place { Code = "25123", IsoCode = "25123", Name = "CACHIPAY - CUNDINAMARCA", Latitude = 4.73092890716, Longitude = -74.4359526602 },
new Place { Code = "25126", IsoCode = "25126", Name = "CAJICÁ - CUNDINAMARCA", Latitude = 4.92087291414, Longitude = -74.0236365343 },
new Place { Code = "25148", IsoCode = "25148", Name = "CAPARRAPÍ - CUNDINAMARCA", Latitude = 5.34357122073, Longitude = -74.4921952724 },
new Place { Code = "25151", IsoCode = "25151", Name = "CÁQUEZA - CUNDINAMARCA", Latitude = 4.40366546922, Longitude = -73.9465739177 },
new Place { Code = "25154", IsoCode = "25154", Name = "CARMEN DE CARUPA - CUNDINAMARCA", Latitude = 5.34908578768, Longitude = -73.9009831039 },
new Place { Code = "25168", IsoCode = "25168", Name = "CHAGUANÍ - CUNDINAMARCA", Latitude = 4.94773060064, Longitude = -74.592714462 },
new Place { Code = "25175", IsoCode = "25175", Name = "CHÍA - CUNDINAMARCA", Latitude = 4.86580207151, Longitude = -74.0496481882 },
new Place { Code = "25178", IsoCode = "25178", Name = "CHIPAQUE - CUNDINAMARCA", Latitude = 4.44253070667, Longitude = -74.0445981737 },
new Place { Code = "25181", IsoCode = "25181", Name = "CHOACHÍ - CUNDINAMARCA", Latitude = 4.52901585653, Longitude = -73.9229671902 },
new Place { Code = "25183", IsoCode = "25183", Name = "CHOCONTÁ - CUNDINAMARCA", Latitude = 5.14485856952, Longitude = -73.6832205258 },
new Place { Code = "25200", IsoCode = "25200", Name = "COGUA - CUNDINAMARCA", Latitude = 5.06180883195, Longitude = -73.9782582487 },
new Place { Code = "25214", IsoCode = "25214", Name = "COTA - CUNDINAMARCA", Latitude = 4.8087009681, Longitude = -74.1029336394 },
new Place { Code = "25224", IsoCode = "25224", Name = "CUCUNUBÁ - CUNDINAMARCA", Latitude = 5.25059033207, Longitude = -73.766310612 },
new Place { Code = "25245", IsoCode = "25245", Name = "EL COLEGIO - CUNDINAMARCA", Latitude = 4.57826466852, Longitude = -74.442739512 },
new Place { Code = "25258", IsoCode = "25258", Name = "EL PEÑÓN - CUNDINAMARCA", Latitude = 5.24908341275, Longitude = -74.2901625904 },
new Place { Code = "25260", IsoCode = "25260", Name = "EL ROSAL - CUNDINAMARCA", Latitude = 4.85239455377, Longitude = -74.2619231756 },
new Place { Code = "25269", IsoCode = "25269", Name = "FACATATIVÁ - CUNDINAMARCA", Latitude = 4.81224201458, Longitude = -74.3510146905 },
new Place { Code = "25279", IsoCode = "25279", Name = "FÓMEQUE - CUNDINAMARCA", Latitude = 4.48489559982, Longitude = -73.8927335149 },
new Place { Code = "25281", IsoCode = "25281", Name = "FOSCA - CUNDINAMARCA", Latitude = 4.33873601179, Longitude = -73.9392954783 },
new Place { Code = "25286", IsoCode = "25286", Name = "FUNZA - CUNDINAMARCA", Latitude = 4.70865653894, Longitude = -74.2019793976 },
new Place { Code = "25288", IsoCode = "25288", Name = "FÚQUENE - CUNDINAMARCA", Latitude = 5.40400391041, Longitude = -73.7958097988 },
new Place { Code = "25290", IsoCode = "25290", Name = "FUSAGASUGÁ - CUNDINAMARCA", Latitude = 4.33774814193, Longitude = -74.3663679701 },
new Place { Code = "25293", IsoCode = "25293", Name = "GACHALÁ - CUNDINAMARCA", Latitude = 4.69319201434, Longitude = -73.5208054785 },
new Place { Code = "25295", IsoCode = "25295", Name = "GACHANCIPÁ - CUNDINAMARCA", Latitude = 4.99105037518, Longitude = -73.872917556 },
new Place { Code = "25297", IsoCode = "25297", Name = "GACHETÁ - CUNDINAMARCA", Latitude = 4.81632975702, Longitude = -73.636486426 },
new Place { Code = "25299", IsoCode = "25299", Name = "GAMA - CUNDINAMARCA", Latitude = 4.76258311838, Longitude = -73.6107849968 },
new Place { Code = "25307", IsoCode = "25307", Name = "GIRARDOT - CUNDINAMARCA", Latitude = 4.30370548896, Longitude = -74.8104629426 },
new Place { Code = "25312", IsoCode = "25312", Name = "GRANADA - CUNDINAMARCA", Latitude = 4.51964068691, Longitude = -74.3507494579 },
new Place { Code = "25317", IsoCode = "25317", Name = "GUACHETÁ - CUNDINAMARCA", Latitude = 5.38359008958, Longitude = -73.6868961185 },
new Place { Code = "25320", IsoCode = "25320", Name = "GUADUAS - CUNDINAMARCA", Latitude = 5.07248999376, Longitude = -74.603414551 },
new Place { Code = "25322", IsoCode = "25322", Name = "GUASCA - CUNDINAMARCA", Latitude = 4.86754875217, Longitude = -73.878069051 },
new Place { Code = "25324", IsoCode = "25324", Name = "GUATAQUÍ - CUNDINAMARCA", Latitude = 4.51810415836, Longitude = -74.7903274636 },
new Place { Code = "25326", IsoCode = "25326", Name = "GUATAVITA - CUNDINAMARCA", Latitude = 4.93396486437, Longitude = -73.8333374514 },
new Place { Code = "25328", IsoCode = "25328", Name = "GUAYABAL DE SÍQUIMA - CUNDINAMARCA", Latitude = 4.87794137161, Longitude = -74.4673483566 },
new Place { Code = "25335", IsoCode = "25335", Name = "GUAYABETAL - CUNDINAMARCA", Latitude = 4.2170694586, Longitude = -73.8170325455 },
new Place { Code = "25339", IsoCode = "25339", Name = "GUTIÉRREZ - CUNDINAMARCA", Latitude = 4.25493902272, Longitude = -74.002986808 },
new Place { Code = "25368", IsoCode = "25368", Name = "JERUSALÉN - CUNDINAMARCA", Latitude = 4.56243784729, Longitude = -74.6946601122 },
new Place { Code = "25372", IsoCode = "25372", Name = "JUNÍN - CUNDINAMARCA", Latitude = 4.79029733471, Longitude = -73.662973651 },
new Place { Code = "25377", IsoCode = "25377", Name = "LA CALERA - CUNDINAMARCA", Latitude = 4.72014400857, Longitude = -73.9701238854 },
new Place { Code = "25386", IsoCode = "25386", Name = "LA MESA - CUNDINAMARCA", Latitude = 4.63537372117, Longitude = -74.4542881209 },
new Place { Code = "25394", IsoCode = "25394", Name = "LA PALMA - CUNDINAMARCA", Latitude = 5.35896522525, Longitude = -74.3909112772 },
new Place { Code = "25398", IsoCode = "25398", Name = "LA PEÑA - CUNDINAMARCA", Latitude = 5.19887437828, Longitude = -74.3940765359 },
new Place { Code = "25402", IsoCode = "25402", Name = "LA VEGA - CUNDINAMARCA", Latitude = 4.99054270397, Longitude = -74.3311543673 },
new Place { Code = "25407", IsoCode = "25407", Name = "LENGUAZAQUE - CUNDINAMARCA", Latitude = 5.30602649574, Longitude = -73.7114452271 },
new Place { Code = "25426", IsoCode = "25426", Name = "MACHETÁ - CUNDINAMARCA", Latitude = 5.0799154903, Longitude = -73.6065091545 },
new Place { Code = "25430", IsoCode = "25430", Name = "MADRID - CUNDINAMARCA", Latitude = 4.73284520314, Longitude = -74.2667554524 },
new Place { Code = "25436", IsoCode = "25436", Name = "MANTA - CUNDINAMARCA", Latitude = 5.00919863012, Longitude = -73.5404699987 },
new Place { Code = "25438", IsoCode = "25438", Name = "MEDINA - CUNDINAMARCA", Latitude = 4.50865387796, Longitude = -73.3505279079 },
new Place { Code = "25473", IsoCode = "25473", Name = "MOSQUERA - CUNDINAMARCA", Latitude = 4.71430462524, Longitude = -74.2282684727 },
new Place { Code = "25483", IsoCode = "25483", Name = "NARIÑO - CUNDINAMARCA", Latitude = 4.39920338244, Longitude = -74.8267466425 },
new Place { Code = "25486", IsoCode = "25486", Name = "NEMOCÓN - CUNDINAMARCA", Latitude = 5.06759181007, Longitude = -73.8788906876 },
new Place { Code = "25488", IsoCode = "25488", Name = "NILO - CUNDINAMARCA", Latitude = 4.30686374054, Longitude = -74.6205087644 },
new Place { Code = "25489", IsoCode = "25489", Name = "NIMAIMA - CUNDINAMARCA", Latitude = 5.12592170134, Longitude = -74.3866002203 },
new Place { Code = "25491", IsoCode = "25491", Name = "NOCAIMA - CUNDINAMARCA", Latitude = 5.06941560618, Longitude = -74.3774736098 },
new Place { Code = "25506", IsoCode = "25506", Name = "VENECIA - CUNDINAMARCA", Latitude = 4.08916639341, Longitude = -74.4777195337 },
new Place { Code = "25513", IsoCode = "25513", Name = "PACHO - CUNDINAMARCA", Latitude = 5.1508200093, Longitude = -74.1461795404 },
new Place { Code = "25518", IsoCode = "25518", Name = "PAIME - CUNDINAMARCA", Latitude = 5.370820318, Longitude = -74.1528046237 },
new Place { Code = "25524", IsoCode = "25524", Name = "PANDI - CUNDINAMARCA", Latitude = 4.19123152625, Longitude = -74.4867344587 },
new Place { Code = "25530", IsoCode = "25530", Name = "PARATEBUENO - CUNDINAMARCA", Latitude = 4.37502628853, Longitude = -73.2128638635 },
new Place { Code = "25535", IsoCode = "25535", Name = "PASCA - CUNDINAMARCA", Latitude = 4.31027283605, Longitude = -74.3049760038 },
new Place { Code = "25572", IsoCode = "25572", Name = "PUERTO SALGAR - CUNDINAMARCA", Latitude = 5.46497923712, Longitude = -74.6527181227 },
new Place { Code = "25580", IsoCode = "25580", Name = "PULÍ - CUNDINAMARCA", Latitude = 4.68153163114, Longitude = -74.7149545601 },
new Place { Code = "25592", IsoCode = "25592", Name = "QUEBRADANEGRA - CUNDINAMARCA", Latitude = 5.11823402805, Longitude = -74.4799157399 },
new Place { Code = "25594", IsoCode = "25594", Name = "QUETAME - CUNDINAMARCA", Latitude = 4.32984569491, Longitude = -73.8629352741 },
new Place { Code = "25596", IsoCode = "25596", Name = "QUIPILE - CUNDINAMARCA", Latitude = 4.74473436, Longitude = -74.5334510616 },
new Place { Code = "25599", IsoCode = "25599", Name = "APULO - CUNDINAMARCA", Latitude = 4.52796012335, Longitude = -74.5892974772 },
new Place { Code = "25612", IsoCode = "25612", Name = "RICAURTE - CUNDINAMARCA", Latitude = 4.28409029975, Longitude = -74.7739208228 },
new Place { Code = "25645", IsoCode = "25645", Name = "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", Latitude = 4.61607411706, Longitude = -74.3518163072 },
new Place { Code = "25649", IsoCode = "25649", Name = "SAN BERNARDO - CUNDINAMARCA", Latitude = 4.18027585646, Longitude = -74.4245212301 },
new Place { Code = "25653", IsoCode = "25653", Name = "SAN CAYETANO - CUNDINAMARCA", Latitude = 5.3332487719, Longitude = -74.0232151772 },
new Place { Code = "25658", IsoCode = "25658", Name = "SAN FRANCISCO - CUNDINAMARCA", Latitude = 4.97248326158, Longitude = -74.2896976345 },
new Place { Code = "25662", IsoCode = "25662", Name = "SAN JUAN DE RIOSECO - CUNDINAMARCA", Latitude = 4.84725315287, Longitude = -74.621655905 },
new Place { Code = "25718", IsoCode = "25718", Name = "SASAIMA - CUNDINAMARCA", Latitude = 4.96211397458, Longitude = -74.4329479077 },
new Place { Code = "25736", IsoCode = "25736", Name = "SESQUILÉ - CUNDINAMARCA", Latitude = 5.0451953391, Longitude = -73.7967351846 },
new Place { Code = "25740", IsoCode = "25740", Name = "SIBATÉ - CUNDINAMARCA", Latitude = 4.48787134322, Longitude = -74.258749391 },
new Place { Code = "25743", IsoCode = "25743", Name = "SILVANIA - CUNDINAMARCA", Latitude = 4.38132922601, Longitude = -74.404636826 },
new Place { Code = "25745", IsoCode = "25745", Name = "SIMIJACA - CUNDINAMARCA", Latitude = 5.50477875195, Longitude = -73.8501021221 },
new Place { Code = "25754", IsoCode = "25754", Name = "SOACHA - CUNDINAMARCA", Latitude = 4.58639001648, Longitude = -74.1949015405 },
new Place { Code = "25758", IsoCode = "25758", Name = "SOPÓ - CUNDINAMARCA", Latitude = 4.90694243699, Longitude = -73.9388852876 },
new Place { Code = "25769", IsoCode = "25769", Name = "SUBACHOQUE - CUNDINAMARCA", Latitude = 4.92837400479, Longitude = -74.1722359631 },
new Place { Code = "25772", IsoCode = "25772", Name = "SUESCA - CUNDINAMARCA", Latitude = 5.10343692597, Longitude = -73.7983610513 },
new Place { Code = "25777", IsoCode = "25777", Name = "SUPATÁ - CUNDINAMARCA", Latitude = 5.06181223997, Longitude = -74.2358358078 },
new Place { Code = "25779", IsoCode = "25779", Name = "SUSA - CUNDINAMARCA", Latitude = 5.45327943347, Longitude = -73.8136833668 },
new Place { Code = "25781", IsoCode = "25781", Name = "SUTATAUSA - CUNDINAMARCA", Latitude = 5.2473689617, Longitude = -73.8530083914 },
new Place { Code = "25785", IsoCode = "25785", Name = "TABIO - CUNDINAMARCA", Latitude = 4.9164173473, Longitude = -74.0984754623 },
new Place { Code = "25793", IsoCode = "25793", Name = "TAUSA - CUNDINAMARCA", Latitude = 5.19568350829, Longitude = -73.8875918059 },
new Place { Code = "25797", IsoCode = "25797", Name = "TENA - CUNDINAMARCA", Latitude = 4.6552672945, Longitude = -74.3896312414 },
new Place { Code = "25799", IsoCode = "25799", Name = "TENJO - CUNDINAMARCA", Latitude = 4.87171577268, Longitude = -74.1434518171 },
new Place { Code = "25805", IsoCode = "25805", Name = "TIBACUY - CUNDINAMARCA", Latitude = 4.34801043663, Longitude = -74.4525463161 },
new Place { Code = "25807", IsoCode = "25807", Name = "TIBIRITA - CUNDINAMARCA", Latitude = 5.05244592211, Longitude = -73.5046538029 },
new Place { Code = "25815", IsoCode = "25815", Name = "TOCAIMA - CUNDINAMARCA", Latitude = 4.46092251893, Longitude = -74.6359025106 },
new Place { Code = "25817", IsoCode = "25817", Name = "TOCANCIPÁ - CUNDINAMARCA", Latitude = 4.96514274816, Longitude = -73.9117458065 },
new Place { Code = "25823", IsoCode = "25823", Name = "TOPAIPÍ - CUNDINAMARCA", Latitude = 5.33581787388, Longitude = -74.3018757174 },
new Place { Code = "25839", IsoCode = "25839", Name = "UBALÁ - CUNDINAMARCA", Latitude = 4.74817719383, Longitude = -73.5323067672 },
new Place { Code = "25841", IsoCode = "25841", Name = "UBAQUE - CUNDINAMARCA", Latitude = 4.48378896934, Longitude = -73.9341737281 },
new Place { Code = "25843", IsoCode = "25843", Name = "VILLA DE SAN DIEGO DE UBATÉ - CUNDINAMARCA", Latitude = 5.30516427858, Longitude = -73.819612402 },
new Place { Code = "25845", IsoCode = "25845", Name = "UNE - CUNDINAMARCA", Latitude = 4.40260375845, Longitude = -74.0252070679 },
new Place { Code = "25851", IsoCode = "25851", Name = "ÚTICA - CUNDINAMARCA", Latitude = 5.19089695391, Longitude = -74.4835295388 },
new Place { Code = "25862", IsoCode = "25862", Name = "VERGARA - CUNDINAMARCA", Latitude = 5.11812063068, Longitude = -74.3454678068 },
new Place { Code = "25867", IsoCode = "25867", Name = "VIANÍ - CUNDINAMARCA", Latitude = 4.87524411005, Longitude = -74.5614873454 },
new Place { Code = "25871", IsoCode = "25871", Name = "VILLAGÓMEZ - CUNDINAMARCA", Latitude = 5.27318303948, Longitude = -74.1951646544 },
new Place { Code = "25873", IsoCode = "25873", Name = "VILLAPINZÓN - CUNDINAMARCA", Latitude = 5.21481263033, Longitude = -73.5968135965 },
new Place { Code = "25875", IsoCode = "25875", Name = "VILLETA - CUNDINAMARCA", Latitude = 5.00942832997, Longitude = -74.4728933192 },
new Place { Code = "25878", IsoCode = "25878", Name = "VIOTÁ - CUNDINAMARCA", Latitude = 4.44050176757, Longitude = -74.5229563819 },
new Place { Code = "25885", IsoCode = "25885", Name = "YACOPÍ - CUNDINAMARCA", Latitude = 5.45953992922, Longitude = -74.3384266368 },
new Place { Code = "25898", IsoCode = "25898", Name = "ZIPACÓN - CUNDINAMARCA", Latitude = 4.76009498133, Longitude = -74.3794037269 },
new Place { Code = "25899", IsoCode = "25899", Name = "ZIPAQUIRÁ - CUNDINAMARCA", Latitude = 5.02348294157, Longitude = -73.9924030664 },
new Place { Code = "27001", IsoCode = "27001", Name = "QUIBDÓ - CHOCÓ", Latitude = 5.69234946505, Longitude = -76.6511246326 },
new Place { Code = "27006", IsoCode = "27006", Name = "ACANDÍ - CHOCÓ", Latitude = 8.5109498959, Longitude = -77.2786180632 },
new Place { Code = "27025", IsoCode = "27025", Name = "ALTO BAUDÓ - CHOCÓ", Latitude = 5.51548003909, Longitude = -76.975714731 },
new Place { Code = "27050", IsoCode = "27050", Name = "ATRATO - CHOCÓ", Latitude = 5.53113252017, Longitude = -76.6361819732 },
new Place { Code = "27073", IsoCode = "27073", Name = "BAGADÓ - CHOCÓ", Latitude = 5.41171542089, Longitude = -76.415960274 },
new Place { Code = "27075", IsoCode = "27075", Name = "BAHÍA SOLANO - CHOCÓ", Latitude = 6.2244703848, Longitude = -77.4037730964 },
new Place { Code = "27077", IsoCode = "27077", Name = "BAJO BAUDÓ - CHOCÓ", Latitude = 4.95394902999, Longitude = -77.36431791 },
new Place { Code = "27099", IsoCode = "27099", Name = "BOJAYÁ - CHOCÓ", Latitude = 6.56638862031, Longitude = -76.8925022166 },
new Place { Code = "27135", IsoCode = "27135", Name = "EL CANTÓN DEL SAN PABLO - CHOCÓ", Latitude = 5.33538667137, Longitude = -76.7272200613 },
new Place { Code = "27150", IsoCode = "27150", Name = "CARMEN DEL DARIÉN - CHOCÓ", Latitude = 7.1576591548, Longitude = -76.9703396152 },
new Place { Code = "27160", IsoCode = "27160", Name = "CÉRTEGUI - CHOCÓ", Latitude = 5.3722504687, Longitude = -76.6113920392 },
new Place { Code = "27205", IsoCode = "27205", Name = "CONDOTO - CHOCÓ", Latitude = 5.09350793861, Longitude = -76.6465174314 },
new Place { Code = "27245", IsoCode = "27245", Name = "EL CARMEN DE ATRATO - CHOCÓ", Latitude = 5.90066567336, Longitude = -76.1419665724 },
new Place { Code = "27250", IsoCode = "27250", Name = "EL LITORAL DEL SAN JUAN - CHOCÓ", Latitude = 4.25519588917, Longitude = -77.363855343 },
new Place { Code = "27361", IsoCode = "27361", Name = "ISTMINA - CHOCÓ", Latitude = 5.15335100326, Longitude = -76.6860015418 },
new Place { Code = "27372", IsoCode = "27372", Name = "JURADÓ - CHOCÓ", Latitude = 7.10603959523, Longitude = -77.7646171026 },
new Place { Code = "27413", IsoCode = "27413", Name = "LLORÓ - CHOCÓ", Latitude = 5.49996186169, Longitude = -76.5425247368 },
new Place { Code = "27425", IsoCode = "27425", Name = "MEDIO ATRATO - CHOCÓ", Latitude = 5.99437489181, Longitude = -76.7811624583 },
new Place { Code = "27430", IsoCode = "27430", Name = "MEDIO BAUDÓ - CHOCÓ", Latitude = 5.0509316568, Longitude = -77.052376141 },
new Place { Code = "27450", IsoCode = "27450", Name = "MEDIO SAN JUAN - CHOCÓ", Latitude = 5.09660896906, Longitude = -76.6955301156 },
new Place { Code = "27491", IsoCode = "27491", Name = "NÓVITA - CHOCÓ", Latitude = 4.9560945273, Longitude = -76.6070694539 },
new Place { Code = "27495", IsoCode = "27495", Name = "NUQUÍ - CHOCÓ", Latitude = 5.70573912127, Longitude = -77.2702238384 },
new Place { Code = "27580", IsoCode = "27580", Name = "RÍO IRÓ - CHOCÓ", Latitude = 5.18546672085, Longitude = -76.4723380556 },
new Place { Code = "27600", IsoCode = "27600", Name = "RÍO QUITO - CHOCÓ", Latitude = 5.48344068064, Longitude = -76.7392442664 },
new Place { Code = "27615", IsoCode = "27615", Name = "RIOSUCIO - CHOCÓ", Latitude = 7.43338275345, Longitude = -77.1111098376 },
new Place { Code = "27660", IsoCode = "27660", Name = "SAN JOSÉ DEL PALMAR - CHOCÓ", Latitude = 4.89467123826, Longitude = -76.235669636 },
new Place { Code = "27745", IsoCode = "27745", Name = "SIPÍ - CHOCÓ", Latitude = 4.65411491722, Longitude = -76.6433845475 },
new Place { Code = "27787", IsoCode = "27787", Name = "TADÓ - CHOCÓ", Latitude = 5.26542599352, Longitude = -76.554776305 },
new Place { Code = "27800", IsoCode = "27800", Name = "UNGUÍA - CHOCÓ", Latitude = 8.04363271503, Longitude = -77.0932294833 },
new Place { Code = "27810", IsoCode = "27810", Name = "UNIÓN PANAMERICANA - CHOCÓ", Latitude = 5.28067211322, Longitude = -76.6310530503 },
new Place { Code = "41001", IsoCode = "41001", Name = "NEIVA - HUILA", Latitude = 2.93554559251, Longitude = -75.2779458694 },
new Place { Code = "41006", IsoCode = "41006", Name = "ACEVEDO - HUILA", Latitude = 1.8043274263, Longitude = -75.8919935956 },
new Place { Code = "41013", IsoCode = "41013", Name = "AGRADO - HUILA", Latitude = 2.26001844092, Longitude = -75.7710499139 },
new Place { Code = "41016", IsoCode = "41016", Name = "AIPE - HUILA", Latitude = 3.22356323875, Longitude = -75.2411436021 },
new Place { Code = "41020", IsoCode = "41020", Name = "ALGECIRAS - HUILA", Latitude = 2.52255590499, Longitude = -75.3156946519 },
new Place { Code = "41026", IsoCode = "41026", Name = "ALTAMIRA - HUILA", Latitude = 2.06340890548, Longitude = -75.7886555897 },
new Place { Code = "41078", IsoCode = "41078", Name = "BARAYA - HUILA", Latitude = 3.15327369237, Longitude = -75.0542906664 },
new Place { Code = "41132", IsoCode = "41132", Name = "CAMPOALEGRE - HUILA", Latitude = 2.68418035182, Longitude = -75.3260352533 },
new Place { Code = "41206", IsoCode = "41206", Name = "COLOMBIA - HUILA", Latitude = 3.37652482145, Longitude = -74.8028951615 },
new Place { Code = "41244", IsoCode = "41244", Name = "ELÍAS - HUILA", Latitude = 2.01339620267, Longitude = -75.9381064222 },
new Place { Code = "41298", IsoCode = "41298", Name = "GARZÓN - HUILA", Latitude = 2.19565280171, Longitude = -75.6267382299 },
new Place { Code = "41306", IsoCode = "41306", Name = "GIGANTE - HUILA", Latitude = 2.38783133576, Longitude = -75.5457294756 },
new Place { Code = "41319", IsoCode = "41319", Name = "GUADALUPE - HUILA", Latitude = 2.02297348548, Longitude = -75.7590386418 },
new Place { Code = "41349", IsoCode = "41349", Name = "HOBO - HUILA", Latitude = 2.58346785394, Longitude = -75.4526284391 },
new Place { Code = "41357", IsoCode = "41357", Name = "ÍQUIRA - HUILA", Latitude = 2.65000134507, Longitude = -75.6350419181 },
new Place { Code = "41359", IsoCode = "41359", Name = "ISNOS - HUILA", Latitude = 1.93035577877, Longitude = -76.2145418301 },
new Place { Code = "41378", IsoCode = "41378", Name = "LA ARGENTINA - HUILA", Latitude = 2.19897948866, Longitude = -75.9791654498 },
new Place { Code = "41396", IsoCode = "41396", Name = "LA PLATA - HUILA", Latitude = 2.38932771847, Longitude = -75.8911122161 },
new Place { Code = "41483", IsoCode = "41483", Name = "NÁTAGA - HUILA", Latitude = 2.54618538725, Longitude = -75.8093159945 },
new Place { Code = "41503", IsoCode = "41503", Name = "OPORAPA - HUILA", Latitude = 2.02415893714, Longitude = -75.9975535895 },
new Place { Code = "41518", IsoCode = "41518", Name = "PAICOL - HUILA", Latitude = 2.44961436155, Longitude = -75.7750976769 },
new Place { Code = "41524", IsoCode = "41524", Name = "PALERMO - HUILA", Latitude = 2.8866588236, Longitude = -75.4327850915 },
new Place { Code = "41530", IsoCode = "41530", Name = "PALESTINA - HUILA", Latitude = 1.72319912364, Longitude = -76.1328690995 },
new Place { Code = "41548", IsoCode = "41548", Name = "PITAL - HUILA", Latitude = 2.26725490632, Longitude = -75.8048973405 },
new Place { Code = "41551", IsoCode = "41551", Name = "PITALITO - HUILA", Latitude = 1.85414505113, Longitude = -76.0404004061 },
new Place { Code = "41615", IsoCode = "41615", Name = "RIVERA - HUILA", Latitude = 2.77789683275, Longitude = -75.2548587698 },
new Place { Code = "41660", IsoCode = "41660", Name = "SALADOBLANCO - HUILA", Latitude = 1.99259538773, Longitude = -76.0462141263 },
new Place { Code = "41668", IsoCode = "41668", Name = "SAN AGUSTÍN - HUILA", Latitude = 1.88147214878, Longitude = -76.2708135539 },
new Place { Code = "41676", IsoCode = "41676", Name = "SANTA MARÍA - HUILA", Latitude = 2.93871220405, Longitude = -75.5867989746 },
new Place { Code = "41770", IsoCode = "41770", Name = "SUAZA - HUILA", Latitude = 1.97693441471, Longitude = -75.7946571509 },
new Place { Code = "41791", IsoCode = "41791", Name = "TARQUI - HUILA", Latitude = 2.10954161946, Longitude = -75.8267661971 },
new Place { Code = "41797", IsoCode = "41797", Name = "TESALIA - HUILA", Latitude = 2.48591120241, Longitude = -75.7274434437 },
new Place { Code = "41799", IsoCode = "41799", Name = "TELLO - HUILA", Latitude = 3.06742822979, Longitude = -75.1392351017 },
new Place { Code = "41801", IsoCode = "41801", Name = "TERUEL - HUILA", Latitude = 2.74125546099, Longitude = -75.5677286846 },
new Place { Code = "41807", IsoCode = "41807", Name = "TIMANÁ - HUILA", Latitude = 1.97430010243, Longitude = -75.9323485772 },
new Place { Code = "41872", IsoCode = "41872", Name = "VILLAVIEJA - HUILA", Latitude = 3.21924054733, Longitude = -75.2181443889 },
new Place { Code = "41885", IsoCode = "41885", Name = "YAGUARÁ - HUILA", Latitude = 2.66479668805, Longitude = -75.5182961686 },
new Place { Code = "44001", IsoCode = "44001", Name = "RIOHACHA - LA GUAJIRA", Latitude = 11.5291254274, Longitude = -72.9122712549 },
new Place { Code = "44035", IsoCode = "44035", Name = "ALBANIA - LA GUAJIRA", Latitude = 11.1627111514, Longitude = -72.5887556379 },
new Place { Code = "44078", IsoCode = "44078", Name = "BARRANCAS - LA GUAJIRA", Latitude = 10.9531042648, Longitude = -72.7961870689 },
new Place { Code = "44090", IsoCode = "44090", Name = "DIBULLA - LA GUAJIRA", Latitude = 11.2712541238, Longitude = -73.3072366877 },
new Place { Code = "44098", IsoCode = "44098", Name = "DISTRACCIÓN - LA GUAJIRA", Latitude = 10.8957747246, Longitude = -72.8857994234 },
new Place { Code = "44110", IsoCode = "44110", Name = "EL MOLINO - LA GUAJIRA", Latitude = 10.651063157, Longitude = -72.9216582848 },
new Place { Code = "44279", IsoCode = "44279", Name = "FONSECA - LA GUAJIRA", Latitude = 10.8866438, Longitude = -72.8504714896 },
new Place { Code = "44378", IsoCode = "44378", Name = "HATONUEVO - LA GUAJIRA", Latitude = 11.0672820787, Longitude = -72.7625018015 },
new Place { Code = "44420", IsoCode = "44420", Name = "LA JAGUA DEL PILAR - LA GUAJIRA", Latitude = 10.5107506772, Longitude = -73.0715949487 },
new Place { Code = "44430", IsoCode = "44430", Name = "MAICAO - LA GUAJIRA", Latitude = 11.3774000042, Longitude = -72.2430361521 },
new Place { Code = "44560", IsoCode = "44560", Name = "MANAURE - LA GUAJIRA", Latitude = 11.7699944929, Longitude = -72.4411882986 },
new Place { Code = "44650", IsoCode = "44650", Name = "SAN JUAN DEL CESAR - LA GUAJIRA", Latitude = 10.7707349804, Longitude = -73.0017013871 },
new Place { Code = "44847", IsoCode = "44847", Name = "URIBIA - LA GUAJIRA", Latitude = 11.7152021401, Longitude = -72.2657462846 },
new Place { Code = "44855", IsoCode = "44855", Name = "URUMITA - LA GUAJIRA", Latitude = 10.5599833381, Longitude = -73.0133716879 },
new Place { Code = "44874", IsoCode = "44874", Name = "VILLANUEVA - LA GUAJIRA", Latitude = 10.610184984, Longitude = -72.9775939067 },
new Place { Code = "47001", IsoCode = "47001", Name = "SANTA MARTA - MAGDALENA", Latitude = 11.2257031416, Longitude = -74.1883970496 },
new Place { Code = "47030", IsoCode = "47030", Name = "ALGARROBO - MAGDALENA", Latitude = 10.1844965575, Longitude = -74.0606684902 },
new Place { Code = "47053", IsoCode = "47053", Name = "ARACATACA - MAGDALENA", Latitude = 10.5906724298, Longitude = -74.1858590204 },
new Place { Code = "47058", IsoCode = "47058", Name = "ARIGUANÍ - MAGDALENA", Latitude = 9.84737240107, Longitude = -74.2362155595 },
new Place { Code = "47161", IsoCode = "47161", Name = "CERRO DE SAN ANTONIO - MAGDALENA", Latitude = 10.3262615876, Longitude = -74.8687983704 },
new Place { Code = "47170", IsoCode = "47170", Name = "CHIVOLO - MAGDALENA", Latitude = 10.0291380842, Longitude = -74.6252889886 },
new Place { Code = "47189", IsoCode = "47189", Name = "CIÉNAGA - MAGDALENA", Latitude = 11.0074328111, Longitude = -74.241368069 },
new Place { Code = "47205", IsoCode = "47205", Name = "CONCORDIA - MAGDALENA", Latitude = 10.2576584509, Longitude = -74.8334493147 },
new Place { Code = "47245", IsoCode = "47245", Name = "EL BANCO - MAGDALENA", Latitude = 8.99831827352, Longitude = -73.979391715 },
new Place { Code = "47258", IsoCode = "47258", Name = "EL PIÑÓN - MAGDALENA", Latitude = 10.4010789014, Longitude = -74.8251113994 },
new Place { Code = "47268", IsoCode = "47268", Name = "EL RETÉN - MAGDALENA", Latitude = 10.6114342755, Longitude = -74.2686658736 },
new Place { Code = "47288", IsoCode = "47288", Name = "FUNDACIÓN - MAGDALENA", Latitude = 10.5138500419, Longitude = -74.1911819159 },
new Place { Code = "47318", IsoCode = "47318", Name = "GUAMAL - MAGDALENA", Latitude = 9.14490772793, Longitude = -74.2250616454 },
new Place { Code = "47460", IsoCode = "47460", Name = "NUEVA GRANADA - MAGDALENA", Latitude = 9.8055700488, Longitude = -74.3923194202 },
new Place { Code = "47541", IsoCode = "47541", Name = "PEDRAZA - MAGDALENA", Latitude = 10.1869655901, Longitude = -74.916535341 },
new Place { Code = "47545", IsoCode = "47545", Name = "PIJIÑO DEL CARMEN - MAGDALENA", Latitude = 9.33068375571, Longitude = -74.4543614301 },
new Place { Code = "47551", IsoCode = "47551", Name = "PIVIJAY - MAGDALENA", Latitude = 10.4613440094, Longitude = -74.6153957047 },
new Place { Code = "47555", IsoCode = "47555", Name = "PLATO - MAGDALENA", Latitude = 9.79340260608, Longitude = -74.7836448308 },
new Place { Code = "47570", IsoCode = "47570", Name = "PUEBLOVIEJO - MAGDALENA", Latitude = 10.9948495831, Longitude = -74.2819750035 },
new Place { Code = "47605", IsoCode = "47605", Name = "REMOLINO - MAGDALENA", Latitude = 10.7018473844, Longitude = -74.716544936 },
new Place { Code = "47660", IsoCode = "47660", Name = "SABANAS DE SAN ÁNGEL - MAGDALENA", Latitude = 10.0325190219, Longitude = -74.2139612233 },
new Place { Code = "47675", IsoCode = "47675", Name = "SALAMINA - MAGDALENA", Latitude = 10.4900398021, Longitude = -74.7931440971 },
new Place { Code = "47692", IsoCode = "47692", Name = "SAN SEBASTIÁN DE BUENAVISTA - MAGDALENA", Latitude = 9.24098424823, Longitude = -74.3474746121 },
new Place { Code = "47703", IsoCode = "47703", Name = "SAN ZENÓN - MAGDALENA", Latitude = 9.24400707382, Longitude = -74.4997338344 },
new Place { Code = "47707", IsoCode = "47707", Name = "SANTA ANA - MAGDALENA", Latitude = 9.32286178066, Longitude = -74.56741811 },
new Place { Code = "47720", IsoCode = "47720", Name = "SANTA BÁRBARA DE PINTO - MAGDALENA", Latitude = 9.42525493819, Longitude = -74.7089130623 },
new Place { Code = "47745", IsoCode = "47745", Name = "SITIONUEVO - MAGDALENA", Latitude = 10.780737907, Longitude = -74.7231050772 },
new Place { Code = "47798", IsoCode = "47798", Name = "TENERIFE - MAGDALENA", Latitude = 9.89827289343, Longitude = -74.857603887 },
new Place { Code = "47960", IsoCode = "47960", Name = "ZAPAYÁN - MAGDALENA", Latitude = 10.1693570394, Longitude = -74.717120255 },
new Place { Code = "47980", IsoCode = "47980", Name = "ZONA BANANERA - MAGDALENA", Latitude = 10.7627394772, Longitude = -74.1427638342 },
new Place { Code = "50001", IsoCode = "50001", Name = "VILLAVICENCIO - META", Latitude = 4.12295758045, Longitude = -73.626877897 },
new Place { Code = "50006", IsoCode = "50006", Name = "ACACÍAS - META", Latitude = 3.99101402796, Longitude = -73.7656023437 },
new Place { Code = "50110", IsoCode = "50110", Name = "BARRANCA DE UPÍA - META", Latitude = 4.56906866688, Longitude = -72.966582101 },
new Place { Code = "50124", IsoCode = "50124", Name = "CABUYARO - META", Latitude = 4.28826159226, Longitude = -72.7894964501 },
new Place { Code = "50150", IsoCode = "50150", Name = "CASTILLA LA NUEVA - META", Latitude = 3.82798261678, Longitude = -73.689021563 },
new Place { Code = "50223", IsoCode = "50223", Name = "CUBARRAL - META", Latitude = 3.79490489067, Longitude = -73.8350109557 },
new Place { Code = "50226", IsoCode = "50226", Name = "CUMARAL - META", Latitude = 4.26706185387, Longitude = -73.4874864381 },
new Place { Code = "50245", IsoCode = "50245", Name = "EL CALVARIO - META", Latitude = 4.35217015755, Longitude = -73.713455028 },
new Place { Code = "50251", IsoCode = "50251", Name = "EL CASTILLO - META", Latitude = 3.56471902834, Longitude = -73.7941628752 },
new Place { Code = "50270", IsoCode = "50270", Name = "EL DORADO - META", Latitude = 3.73881074337, Longitude = -73.8352362301 },
new Place { Code = "50287", IsoCode = "50287", Name = "FUENTE DE ORO - META", Latitude = 3.46151538939, Longitude = -73.6199889818 },
new Place { Code = "50313", IsoCode = "50313", Name = "GRANADA - META", Latitude = 3.5349351906, Longitude = -73.698477557 },
new Place { Code = "50318", IsoCode = "50318", Name = "GUAMAL - META", Latitude = 3.87974360369, Longitude = -73.7701203762 },
new Place { Code = "50325", IsoCode = "50325", Name = "MAPIRIPÁN - META", Latitude = 2.89200026032, Longitude = -72.1332494945 },
new Place { Code = "50330", IsoCode = "50330", Name = "MESETAS - META", Latitude = 3.3822458552, Longitude = -74.0443664191 },
new Place { Code = "50350", IsoCode = "50350", Name = "LA MACARENA - META", Latitude = 2.18362946977, Longitude = -73.7864661865 },
new Place { Code = "50370", IsoCode = "50370", Name = "URIBE - META", Latitude = 3.23832706828, Longitude = -74.3506713856 },
new Place { Code = "50400", IsoCode = "50400", Name = "LEJANÍAS - META", Latitude = 3.52569113573, Longitude = -74.0244023458 },
new Place { Code = "50450", IsoCode = "50450", Name = "PUERTO CONCORDIA - META", Latitude = 2.62379154225, Longitude = -72.7571004622 },
new Place { Code = "50568", IsoCode = "50568", Name = "PUERTO GAITÁN - META", Latitude = 4.31202705989, Longitude = -72.082954864 },
new Place { Code = "50573", IsoCode = "50573", Name = "PUERTO LÓPEZ - META", Latitude = 4.09347367871, Longitude = -72.9559283195 },
new Place { Code = "50577", IsoCode = "50577", Name = "PUERTO LLERAS - META", Latitude = 3.26940842044, Longitude = -73.3731786644 },
new Place { Code = "50590", IsoCode = "50590", Name = "PUERTO RICO - META", Latitude = 2.94164927563, Longitude = -73.2074860066 },
new Place { Code = "50606", IsoCode = "50606", Name = "RESTREPO - META", Latitude = 4.26098099897, Longitude = -73.5640849963 },
new Place { Code = "50680", IsoCode = "50680", Name = "SAN CARLOS DE GUAROA - META", Latitude = 3.7105344843, Longitude = -73.2415894176 },
new Place { Code = "50683", IsoCode = "50683", Name = "SAN JUAN DE ARAMA - META", Latitude = 3.36910742699, Longitude = -73.8708009368 },
new Place { Code = "50686", IsoCode = "50686", Name = "SAN JUANITO - META", Latitude = 4.45795607596, Longitude = -73.6761936444 },
new Place { Code = "50689", IsoCode = "50689", Name = "SAN MARTÍN - META", Latitude = 3.70161052639, Longitude = -73.6959721847 },
new Place { Code = "50711", IsoCode = "50711", Name = "VISTAHERMOSA - META", Latitude = 3.12759895118, Longitude = -73.7525233173 },
new Place { Code = "52001", IsoCode = "52001", Name = "PASTO - NARIÑO", Latitude = 1.21280859722, Longitude = -77.2782674539 },
new Place { Code = "52019", IsoCode = "52019", Name = "ALBÁN - NARIÑO", Latitude = 1.47394061594, Longitude = -77.0812596923 },
new Place { Code = "52022", IsoCode = "52022", Name = "ALDANA - NARIÑO", Latitude = 0.88224359638, Longitude = -77.7003748185 },
new Place { Code = "52036", IsoCode = "52036", Name = "ANCUYÁ - NARIÑO", Latitude = 1.26245062268, Longitude = -77.5146115719 },
new Place { Code = "52051", IsoCode = "52051", Name = "ARBOLEDA - NARIÑO", Latitude = 1.50342205984, Longitude = -77.1354496867 },
new Place { Code = "52079", IsoCode = "52079", Name = "BARBACOAS - NARIÑO", Latitude = 1.67357164668, Longitude = -78.1382611994 },
new Place { Code = "52083", IsoCode = "52083", Name = "BELÉN - NARIÑO", Latitude = 1.59564430447, Longitude = -77.016287834 },
new Place { Code = "52110", IsoCode = "52110", Name = "BUESACO - NARIÑO", Latitude = 1.37209588218, Longitude = -77.1606740852 },
new Place { Code = "52203", IsoCode = "52203", Name = "COLÓN - NARIÑO", Latitude = 1.64512029958, Longitude = -77.0213346773 },
new Place { Code = "52207", IsoCode = "52207", Name = "CONSACÁ - NARIÑO", Latitude = 1.20719433138, Longitude = -77.4657184135 },
new Place { Code = "52210", IsoCode = "52210", Name = "CONTADERO - NARIÑO", Latitude = 0.908386320471, Longitude = -77.5478326274 },
new Place { Code = "52215", IsoCode = "52215", Name = "CÓRDOBA - NARIÑO", Latitude = 0.853665965806, Longitude = -77.51806895 },
new Place { Code = "52224", IsoCode = "52224", Name = "CUASPÚD - NARIÑO", Latitude = 0.863204501581, Longitude = -77.7262251673 },
new Place { Code = "52227", IsoCode = "52227", Name = "CUMBAL - NARIÑO", Latitude = 0.906450846049, Longitude = -77.7912420697 },
new Place { Code = "52233", IsoCode = "52233", Name = "CUMBITARA - NARIÑO", Latitude = 1.64767179037, Longitude = -77.5784311039 },
new Place { Code = "52240", IsoCode = "52240", Name = "CHACHAGÜÍ - NARIÑO", Latitude = 1.35733301978, Longitude = -77.2810087754 },
new Place { Code = "52250", IsoCode = "52250", Name = "EL CHARCO - NARIÑO", Latitude = 2.4758772781, Longitude = -78.1083281297 },
new Place { Code = "52254", IsoCode = "52254", Name = "EL PEÑOL - NARIÑO", Latitude = 1.45363406894, Longitude = -77.4398362894 },
new Place { Code = "52256", IsoCode = "52256", Name = "EL ROSARIO - NARIÑO", Latitude = 1.74490322467, Longitude = -77.3346286535 },
new Place { Code = "52258", IsoCode = "52258", Name = "EL TABLÓN DE GÓMEZ - NARIÑO", Latitude = 1.42729321308, Longitude = -77.0973463182 },
new Place { Code = "52260", IsoCode = "52260", Name = "EL TAMBO - NARIÑO", Latitude = 1.40798382917, Longitude = -77.390751149 },
new Place { Code = "52287", IsoCode = "52287", Name = "FUNES - NARIÑO", Latitude = 1.00112078455, Longitude = -77.4493739891 },
new Place { Code = "52317", IsoCode = "52317", Name = "GUACHUCAL - NARIÑO", Latitude = 0.960368495971, Longitude = -77.7316556305 },
new Place { Code = "52320", IsoCode = "52320", Name = "GUAITARILLA - NARIÑO", Latitude = 1.13086900013, Longitude = -77.5479120563 },
new Place { Code = "52323", IsoCode = "52323", Name = "GUALMATÁN - NARIÑO", Latitude = 0.919358440058, Longitude = -77.5664755001 },
new Place { Code = "52352", IsoCode = "52352", Name = "ILES - NARIÑO", Latitude = 0.968495857115, Longitude = -77.5213951381 },
new Place { Code = "52354", IsoCode = "52354", Name = "IMUÉS - NARIÑO", Latitude = 1.0551982914, Longitude = -77.4965675723 },
new Place { Code = "52356", IsoCode = "52356", Name = "IPIALES - NARIÑO", Latitude = 0.829031718872, Longitude = -77.646095663 },
new Place { Code = "52378", IsoCode = "52378", Name = "LA CRUZ - NARIÑO", Latitude = 1.60014416755, Longitude = -76.9711823702 },
new Place { Code = "52381", IsoCode = "52381", Name = "LA FLORIDA - NARIÑO", Latitude = 1.29916722678, Longitude = -77.4073937557 },
new Place { Code = "52385", IsoCode = "52385", Name = "LA LLANADA - NARIÑO", Latitude = 1.47292218692, Longitude = -77.5800004243 },
new Place { Code = "52390", IsoCode = "52390", Name = "LA TOLA - NARIÑO", Latitude = 2.39792155095, Longitude = -78.1897982893 },
new Place { Code = "52399", IsoCode = "52399", Name = "LA UNIÓN - NARIÑO", Latitude = 1.59247717673, Longitude = -77.128385668 },
new Place { Code = "52405", IsoCode = "52405", Name = "LEIVA - NARIÑO", Latitude = 1.93449673792, Longitude = -77.3066651005 },
new Place { Code = "52411", IsoCode = "52411", Name = "LINARES - NARIÑO", Latitude = 1.35127830979, Longitude = -77.5236269197 },
new Place { Code = "52418", IsoCode = "52418", Name = "LOS ANDES - NARIÑO", Latitude = 1.49420521996, Longitude = -77.5210875385 },
new Place { Code = "52427", IsoCode = "52427", Name = "MAGÜÍ - NARIÑO", Latitude = 1.76612352667, Longitude = -78.1843036766 },
new Place { Code = "52435", IsoCode = "52435", Name = "MALLAMA - NARIÑO", Latitude = 1.14084161818, Longitude = -77.8646583337 },
new Place { Code = "52473", IsoCode = "52473", Name = "MOSQUERA - NARIÑO", Latitude = 2.50835991384, Longitude = -78.4525462355 },
new Place { Code = "52480", IsoCode = "52480", Name = "NARIÑO - NARIÑO", Latitude = 1.28964559756, Longitude = -77.359664699 },
new Place { Code = "52490", IsoCode = "52490", Name = "OLAYA HERRERA - NARIÑO", Latitude = 2.34754710717, Longitude = -78.3287750397 },
new Place { Code = "52506", IsoCode = "52506", Name = "OSPINA - NARIÑO", Latitude = 1.0588340604, Longitude = -77.5661809508 },
new Place { Code = "52520", IsoCode = "52520", Name = "FRANCISCO PIZARRO - NARIÑO", Latitude = 2.03926684074, Longitude = -78.6582827821 },
new Place { Code = "52540", IsoCode = "52540", Name = "POLICARPA - NARIÑO", Latitude = 1.62869823451, Longitude = -77.4587713765 },
new Place { Code = "52560", IsoCode = "52560", Name = "POTOSÍ - NARIÑO", Latitude = 0.805316202318, Longitude = -77.5742477715 },
new Place { Code = "52565", IsoCode = "52565", Name = "PROVIDENCIA - NARIÑO", Latitude = 1.2379913538, Longitude = -77.5965444343 },
new Place { Code = "52573", IsoCode = "52573", Name = "PUERRES - NARIÑO", Latitude = 0.883414835877, Longitude = -77.5030051333 },
new Place { Code = "52585", IsoCode = "52585", Name = "PUPIALES - NARIÑO", Latitude = 0.8709910533, Longitude = -77.6396036189 },
new Place { Code = "52612", IsoCode = "52612", Name = "RICAURTE - NARIÑO", Latitude = 1.21122770251, Longitude = -77.9939922255 },
new Place { Code = "52621", IsoCode = "52621", Name = "ROBERTO PAYÁN - NARIÑO", Latitude = 1.69698691823, Longitude = -78.2446761093 },
new Place { Code = "52678", IsoCode = "52678", Name = "SAMANIEGO - NARIÑO", Latitude = 1.33227290978, Longitude = -77.6007321214 },
new Place { Code = "52683", IsoCode = "52683", Name = "SANDONÁ - NARIÑO", Latitude = 1.28128758136, Longitude = -77.4773138188 },
new Place { Code = "52685", IsoCode = "52685", Name = "SAN BERNARDO - NARIÑO", Latitude = 1.51443104538, Longitude = -77.0470896311 },
new Place { Code = "52687", IsoCode = "52687", Name = "SAN LORENZO - NARIÑO", Latitude = 1.50282726517, Longitude = -77.2152315266 },
new Place { Code = "52693", IsoCode = "52693", Name = "SAN PABLO - NARIÑO", Latitude = 1.66915803917, Longitude = -77.0127283397 },
new Place { Code = "52694", IsoCode = "52694", Name = "SAN PEDRO DE CARTAGO - NARIÑO", Latitude = 1.5520849352, Longitude = -77.1207419723 },
new Place { Code = "52696", IsoCode = "52696", Name = "SANTA BÁRBARA - NARIÑO", Latitude = 2.45112401509, Longitude = -77.9813937052 },
new Place { Code = "52699", IsoCode = "52699", Name = "SANTACRUZ - NARIÑO", Latitude = 1.22164529241, Longitude = -77.6772944592 },
new Place { Code = "52720", IsoCode = "52720", Name = "SAPUYES - NARIÑO", Latitude = 1.03717522709, Longitude = -77.6222392123 },
new Place { Code = "52786", IsoCode = "52786", Name = "TAMINANGO - NARIÑO", Latitude = 1.57012763762, Longitude = -77.2807279183 },
new Place { Code = "52788", IsoCode = "52788", Name = "TANGUA - NARIÑO", Latitude = 1.09479364234, Longitude = -77.3942990576 },
new Place { Code = "52835", IsoCode = "52835", Name = "SAN ANDRÉS DE TUMACO - NARIÑO", Latitude = 1.75029972282, Longitude = -78.789400969 },
new Place { Code = "52838", IsoCode = "52838", Name = "TÚQUERRES - NARIÑO", Latitude = 1.08663901074, Longitude = -77.6178536323 },
new Place { Code = "52885", IsoCode = "52885", Name = "YACUANQUER - NARIÑO", Latitude = 1.11562696069, Longitude = -77.4029913489 },
new Place { Code = "54001", IsoCode = "54001", Name = "CÚCUTA - NORTE DE SANTANDER", Latitude = 7.90526711655, Longitude = -72.5055909659 },
new Place { Code = "54003", IsoCode = "54003", Name = "ÁBREGO - NORTE DE SANTANDER", Latitude = 8.08120418381, Longitude = -73.2214174328 },
new Place { Code = "54051", IsoCode = "54051", Name = "ARBOLEDAS - NORTE DE SANTANDER", Latitude = 7.64269066476, Longitude = -72.7988340008 },
new Place { Code = "54099", IsoCode = "54099", Name = "BOCHALEMA - NORTE DE SANTANDER", Latitude = 7.61206780961, Longitude = -72.6472817269 },
new Place { Code = "54109", IsoCode = "54109", Name = "BUCARASICA - NORTE DE SANTANDER", Latitude = 8.03944194472, Longitude = -72.8669236776 },
new Place { Code = "54125", IsoCode = "54125", Name = "CÁCOTA - NORTE DE SANTANDER", Latitude = 7.26865159993, Longitude = -72.6424728775 },
new Place { Code = "54128", IsoCode = "54128", Name = "CÁCHIRA - NORTE DE SANTANDER", Latitude = 7.73974335671, Longitude = -73.0496492115 },
new Place { Code = "54172", IsoCode = "54172", Name = "CHINÁCOTA - NORTE DE SANTANDER", Latitude = 7.6025629692, Longitude = -72.6024502906 },
new Place { Code = "54174", IsoCode = "54174", Name = "CHITAGÁ - NORTE DE SANTANDER", Latitude = 7.13853760731, Longitude = -72.6648097105 },
new Place { Code = "54206", IsoCode = "54206", Name = "CONVENCIÓN - NORTE DE SANTANDER", Latitude = 8.46999501786, Longitude = -73.3371949282 },
new Place { Code = "54223", IsoCode = "54223", Name = "CUCUTILLA - NORTE DE SANTANDER", Latitude = 7.53917387611, Longitude = -72.7724467652 },
new Place { Code = "54239", IsoCode = "54239", Name = "DURANIA - NORTE DE SANTANDER", Latitude = 7.71421899786, Longitude = -72.6561980754 },
new Place { Code = "54245", IsoCode = "54245", Name = "EL CARMEN - NORTE DE SANTANDER", Latitude = 8.51075882437, Longitude = -73.4467753988 },
new Place { Code = "54250", IsoCode = "54250", Name = "EL TARRA - NORTE DE SANTANDER", Latitude = 8.57596111348, Longitude = -73.0943939175 },
new Place { Code = "54261", IsoCode = "54261", Name = "EL ZULIA - NORTE DE SANTANDER", Latitude = 7.93707310152, Longitude = -72.6039341161 },
new Place { Code = "54313", IsoCode = "54313", Name = "GRAMALOTE - NORTE DE SANTANDER", Latitude = 7.88756348782, Longitude = -72.7973048329 },
new Place { Code = "54344", IsoCode = "54344", Name = "HACARÍ - NORTE DE SANTANDER", Latitude = 8.32162940594, Longitude = -73.1459084076 },
new Place { Code = "54347", IsoCode = "54347", Name = "HERRÁN - NORTE DE SANTANDER", Latitude = 7.50618537707, Longitude = -72.4831712064 },
new Place { Code = "54377", IsoCode = "54377", Name = "LABATECA - NORTE DE SANTANDER", Latitude = 7.29939120651, Longitude = -72.4949268328 },
new Place { Code = "54385", IsoCode = "54385", Name = "LA ESPERANZA - NORTE DE SANTANDER", Latitude = 7.63949265935, Longitude = -73.3274335869 },
new Place { Code = "54398", IsoCode = "54398", Name = "LA PLAYA - NORTE DE SANTANDER", Latitude = 8.2135938264, Longitude = -73.2381390884 },
new Place { Code = "54405", IsoCode = "54405", Name = "LOS PATIOS - NORTE DE SANTANDER", Latitude = 7.83349267282, Longitude = -72.5060367469 },
new Place { Code = "54418", IsoCode = "54418", Name = "LOURDES - NORTE DE SANTANDER", Latitude = 7.94523586891, Longitude = -72.8320469133 },
new Place { Code = "54480", IsoCode = "54480", Name = "MUTISCUA - NORTE DE SANTANDER", Latitude = 7.30024008229, Longitude = -72.7470801465 },
new Place { Code = "54498", IsoCode = "54498", Name = "OCAÑA - NORTE DE SANTANDER", Latitude = 8.24666636498, Longitude = -73.3551957158 },
new Place { Code = "54518", IsoCode = "54518", Name = "PAMPLONA - NORTE DE SANTANDER", Latitude = 7.37519414845, Longitude = -72.648211059 },
new Place { Code = "54520", IsoCode = "54520", Name = "PAMPLONITA - NORTE DE SANTANDER", Latitude = 7.43585397949, Longitude = -72.6384380135 },
new Place { Code = "54553", IsoCode = "54553", Name = "PUERTO SANTANDER - NORTE DE SANTANDER", Latitude = 8.36117034867, Longitude = -72.4093510006 },
new Place { Code = "54599", IsoCode = "54599", Name = "RAGONVALIA - NORTE DE SANTANDER", Latitude = 7.57746227768, Longitude = -72.4760192272 },
new Place { Code = "54660", IsoCode = "54660", Name = "SALAZAR - NORTE DE SANTANDER", Latitude = 7.7727182846, Longitude = -72.8087686232 },
new Place { Code = "54670", IsoCode = "54670", Name = "SAN CALIXTO - NORTE DE SANTANDER", Latitude = 8.39831528377, Longitude = -73.2066910219 },
new Place { Code = "54673", IsoCode = "54673", Name = "SAN CAYETANO - NORTE DE SANTANDER", Latitude = 7.87727938807, Longitude = -72.6250402901 },
new Place { Code = "54680", IsoCode = "54680", Name = "SANTIAGO - NORTE DE SANTANDER", Latitude = 7.86444785684, Longitude = -72.717069145 },
new Place { Code = "54720", IsoCode = "54720", Name = "SARDINATA - NORTE DE SANTANDER", Latitude = 8.08058603644, Longitude = -72.7982608119 },
new Place { Code = "54743", IsoCode = "54743", Name = "SILOS - NORTE DE SANTANDER", Latitude = 7.20407152749, Longitude = -72.7572391835 },
new Place { Code = "54800", IsoCode = "54800", Name = "TEORAMA - NORTE DE SANTANDER", Latitude = 8.43723373402, Longitude = -73.2869854333 },
new Place { Code = "54810", IsoCode = "54810", Name = "TIBÚ - NORTE DE SANTANDER", Latitude = 8.63971770051, Longitude = -72.7359193717 },
new Place { Code = "54820", IsoCode = "54820", Name = "TOLEDO - NORTE DE SANTANDER", Latitude = 7.29935086688, Longitude = -72.4791068097 },
new Place { Code = "54871", IsoCode = "54871", Name = "VILLA CARO - NORTE DE SANTANDER", Latitude = 7.91436950403, Longitude = -72.9729238448 },
new Place { Code = "54874", IsoCode = "54874", Name = "VILLA DEL ROSARIO - NORTE DE SANTANDER", Latitude = 7.84904659595, Longitude = -72.4705192458 },
new Place { Code = "63001", IsoCode = "63001", Name = "ARMENIA - QUINDÍO", Latitude = 4.53805331619, Longitude = -75.6762454094 },
new Place { Code = "63111", IsoCode = "63111", Name = "BUENAVISTA - QUINDÍO", Latitude = 4.35752520113, Longitude = -75.7383660487 },
new Place { Code = "63130", IsoCode = "63130", Name = "CALARCÁ - QUINDÍO", Latitude = 4.51619928578, Longitude = -75.6490942155 },
new Place { Code = "63190", IsoCode = "63190", Name = "CIRCASIA - QUINDÍO", Latitude = 4.61512679433, Longitude = -75.6356141135 },
new Place { Code = "63212", IsoCode = "63212", Name = "CÓRDOBA - QUINDÍO", Latitude = 4.39327278702, Longitude = -75.6876461954 },
new Place { Code = "63272", IsoCode = "63272", Name = "FILANDIA - QUINDÍO", Latitude = 4.67600719085, Longitude = -75.656183215 },
new Place { Code = "63302", IsoCode = "63302", Name = "GÉNOVA - QUINDÍO", Latitude = 4.2077456618, Longitude = -75.7895561047 },
new Place { Code = "63401", IsoCode = "63401", Name = "LA TEBAIDA - QUINDÍO", Latitude = 4.45288108378, Longitude = -75.7885139466 },
new Place { Code = "63470", IsoCode = "63470", Name = "MONTENEGRO - QUINDÍO", Latitude = 4.5629703568, Longitude = -75.7508086191 },
new Place { Code = "63548", IsoCode = "63548", Name = "PIJAO - QUINDÍO", Latitude = 4.33531325126, Longitude = -75.702514102 },
new Place { Code = "63594", IsoCode = "63594", Name = "QUIMBAYA - QUINDÍO", Latitude = 4.62330250711, Longitude = -75.7629666878 },
new Place { Code = "63690", IsoCode = "63690", Name = "SALENTO - QUINDÍO", Latitude = 4.63727979262, Longitude = -75.5707958324 },
new Place { Code = "66001", IsoCode = "66001", Name = "PEREIRA - RISARALDA", Latitude = 4.80888773215, Longitude = -75.7155099202 },
new Place { Code = "66045", IsoCode = "66045", Name = "APÍA - RISARALDA", Latitude = 5.1061188187, Longitude = -75.941059973 },
new Place { Code = "66075", IsoCode = "66075", Name = "BALBOA - RISARALDA", Latitude = 4.94931342359, Longitude = -75.9566556041 },
new Place { Code = "66088", IsoCode = "66088", Name = "BELÉN DE UMBRÍA - RISARALDA", Latitude = 5.20081910209, Longitude = -75.8684957854 },
new Place { Code = "66170", IsoCode = "66170", Name = "DOSQUEBRADAS - RISARALDA", Latitude = 4.83463403327, Longitude = -75.675182816 },
new Place { Code = "66318", IsoCode = "66318", Name = "GUÁTICA - RISARALDA", Latitude = 5.31491484847, Longitude = -75.7964483643 },
new Place { Code = "66383", IsoCode = "66383", Name = "LA CELIA - RISARALDA", Latitude = 5.00337011185, Longitude = -76.0031932924 },
new Place { Code = "66400", IsoCode = "66400", Name = "LA VIRGINIA - RISARALDA", Latitude = 4.89834379545, Longitude = -75.8796584309 },
new Place { Code = "66440", IsoCode = "66440", Name = "MARSELLA - RISARALDA", Latitude = 4.93666531666, Longitude = -75.7385271493 },
new Place { Code = "66456", IsoCode = "66456", Name = "MISTRATÓ - RISARALDA", Latitude = 5.2946657063, Longitude = -75.8794193338 },
new Place { Code = "66572", IsoCode = "66572", Name = "PUEBLO RICO - RISARALDA", Latitude = 5.22209118931, Longitude = -76.0307989103 },
new Place { Code = "66594", IsoCode = "66594", Name = "QUINCHÍA - RISARALDA", Latitude = 5.34114674188, Longitude = -75.7309367872 },
new Place { Code = "66682", IsoCode = "66682", Name = "SANTA ROSA DE CABAL - RISARALDA", Latitude = 4.87650859907, Longitude = -75.6240743865 },
new Place { Code = "66687", IsoCode = "66687", Name = "SANTUARIO - RISARALDA", Latitude = 5.07367695867, Longitude = -75.9646784973 },
new Place { Code = "68001", IsoCode = "68001", Name = "BUCARAMANGA - SANTANDER", Latitude = 7.12278728534, Longitude = -73.132325231 },
new Place { Code = "68013", IsoCode = "68013", Name = "AGUADA - SANTANDER", Latitude = 6.16212560851, Longitude = -73.5214455038 },
new Place { Code = "68020", IsoCode = "68020", Name = "ALBANIA - SANTANDER", Latitude = 5.75871447289, Longitude = -73.9141803605 },
new Place { Code = "68051", IsoCode = "68051", Name = "ARATOCA - SANTANDER", Latitude = 6.69327919271, Longitude = -73.0201635244 },
new Place { Code = "68077", IsoCode = "68077", Name = "BARBOSA - SANTANDER", Latitude = 5.93031783104, Longitude = -73.6175602711 },
new Place { Code = "68079", IsoCode = "68079", Name = "BARICHARA - SANTANDER", Latitude = 6.63534926286, Longitude = -73.2226819755 },
new Place { Code = "68081", IsoCode = "68081", Name = "BARRANCABERMEJA - SANTANDER", Latitude = 7.06154842252, Longitude = -73.8524943961 },
new Place { Code = "68092", IsoCode = "68092", Name = "BETULIA - SANTANDER", Latitude = 6.90006889458, Longitude = -73.2836658375 },
new Place { Code = "68101", IsoCode = "68101", Name = "BOLÍVAR - SANTANDER", Latitude = 5.98686979159, Longitude = -73.7709122011 },
new Place { Code = "68121", IsoCode = "68121", Name = "CABRERA - SANTANDER", Latitude = 6.59172637074, Longitude = -73.2465433026 },
new Place { Code = "68132", IsoCode = "68132", Name = "CALIFORNIA - SANTANDER", Latitude = 7.34787832886, Longitude = -72.9444849044 },
new Place { Code = "68147", IsoCode = "68147", Name = "CAPITANEJO - SANTANDER", Latitude = 6.53056931982, Longitude = -72.6956351621 },
new Place { Code = "68152", IsoCode = "68152", Name = "CARCASÍ - SANTANDER", Latitude = 6.62673429701, Longitude = -72.626411529 },
new Place { Code = "68160", IsoCode = "68160", Name = "CEPITÁ - SANTANDER", Latitude = 6.75340228765, Longitude = -72.9745168494 },
new Place { Code = "68162", IsoCode = "68162", Name = "CERRITO - SANTANDER", Latitude = 6.84311761625, Longitude = -72.6947276921 },
new Place { Code = "68167", IsoCode = "68167", Name = "CHARALÁ - SANTANDER", Latitude = 6.28533512166, Longitude = -73.1466694378 },
new Place { Code = "68169", IsoCode = "68169", Name = "CHARTA - SANTANDER", Latitude = 7.28125240984, Longitude = -72.9684479094 },
new Place { Code = "68176", IsoCode = "68176", Name = "CHIMA - SANTANDER", Latitude = 6.34191503599, Longitude = -73.3728971006 },
new Place { Code = "68179", IsoCode = "68179", Name = "CHIPATÁ - SANTANDER", Latitude = 6.06258983185, Longitude = -73.6372840635 },
new Place { Code = "68190", IsoCode = "68190", Name = "CIMITARRA - SANTANDER", Latitude = 6.31369089431, Longitude = -73.9548939419 },
new Place { Code = "68207", IsoCode = "68207", Name = "CONCEPCIÓN - SANTANDER", Latitude = 6.76894002245, Longitude = -72.6942957138 },
new Place { Code = "68209", IsoCode = "68209", Name = "CONFINES - SANTANDER", Latitude = 6.3573553496, Longitude = -73.2410236941 },
new Place { Code = "68211", IsoCode = "68211", Name = "CONTRATACIÓN - SANTANDER", Latitude = 6.29046114389, Longitude = -73.4743899923 },
new Place { Code = "68217", IsoCode = "68217", Name = "COROMORO - SANTANDER", Latitude = 6.29555598059, Longitude = -73.0405439487 },
new Place { Code = "68229", IsoCode = "68229", Name = "CURITÍ - SANTANDER", Latitude = 6.60459799378, Longitude = -73.0689588035 },
new Place { Code = "68235", IsoCode = "68235", Name = "EL CARMEN DE CHUCURÍ - SANTANDER", Latitude = 6.69791160477, Longitude = -73.5131237068 },
new Place { Code = "68245", IsoCode = "68245", Name = "EL GUACAMAYO - SANTANDER", Latitude = 6.24606724973, Longitude = -73.496439338 },
new Place { Code = "68250", IsoCode = "68250", Name = "EL PEÑÓN - SANTANDER", Latitude = 6.0567053411, Longitude = -73.8129614011 },
new Place { Code = "68255", IsoCode = "68255", Name = "EL PLAYÓN - SANTANDER", Latitude = 7.47271835801, Longitude = -73.2046203518 },
new Place { Code = "68264", IsoCode = "68264", Name = "ENCINO - SANTANDER", Latitude = 6.13821535533, Longitude = -73.0992984673 },
new Place { Code = "68266", IsoCode = "68266", Name = "ENCISO - SANTANDER", Latitude = 6.66972347669, Longitude = -72.7001385756 },
new Place { Code = "68271", IsoCode = "68271", Name = "FLORIÁN - SANTANDER", Latitude = 5.80494925362, Longitude = -73.9709635955 },
new Place { Code = "68276", IsoCode = "68276", Name = "FLORIDABLANCA - SANTANDER", Latitude = 7.07732172043, Longitude = -73.099121637 },
new Place { Code = "68296", IsoCode = "68296", Name = "GALÁN - SANTANDER", Latitude = 6.63889865327, Longitude = -73.287914592 },
new Place { Code = "68298", IsoCode = "68298", Name = "GÁMBITA - SANTANDER", Latitude = 5.94583041292, Longitude = -73.3426272948 },
new Place { Code = "68307", IsoCode = "68307", Name = "GIRÓN - SANTANDER", Latitude = 7.07177401245, Longitude = -73.1683126853 },
new Place { Code = "68318", IsoCode = "68318", Name = "GUACA - SANTANDER", Latitude = 6.87687228146, Longitude = -72.8560844295 },
new Place { Code = "68320", IsoCode = "68320", Name = "GUADALUPE - SANTANDER", Latitude = 6.24582467739, Longitude = -73.418891426 },
new Place { Code = "68322", IsoCode = "68322", Name = "GUAPOTÁ - SANTANDER", Latitude = 6.3083874905, Longitude = -73.3209067076 },
new Place { Code = "68324", IsoCode = "68324", Name = "GUAVATÁ - SANTANDER", Latitude = 5.95507658691, Longitude = -73.6999151414 },
new Place { Code = "68327", IsoCode = "68327", Name = "GÜEPSA - SANTANDER", Latitude = 6.02638642861, Longitude = -73.5713144981 },
new Place { Code = "68344", IsoCode = "68344", Name = "HATO - SANTANDER", Latitude = 6.54294063601, Longitude = -73.3081130581 },
new Place { Code = "68368", IsoCode = "68368", Name = "JESÚS MARÍA - SANTANDER", Latitude = 5.87653148988, Longitude = -73.7827825923 },
new Place { Code = "68370", IsoCode = "68370", Name = "JORDÁN - SANTANDER", Latitude = 6.73245858931, Longitude = -73.0967324977 },
new Place { Code = "68377", IsoCode = "68377", Name = "LA BELLEZA - SANTANDER", Latitude = 5.85928066933, Longitude = -73.9649519446 },
new Place { Code = "68385", IsoCode = "68385", Name = "LANDÁZURI - SANTANDER", Latitude = 6.21938700028, Longitude = -73.8090987971 },
new Place { Code = "68397", IsoCode = "68397", Name = "LA PAZ - SANTANDER", Latitude = 6.17856814732, Longitude = -73.5895679473 },
new Place { Code = "68406", IsoCode = "68406", Name = "LEBRIJA - SANTANDER", Latitude = 7.11332219394, Longitude = -73.2196733968 },
new Place { Code = "68418", IsoCode = "68418", Name = "LOS SANTOS - SANTANDER", Latitude = 6.75588428991, Longitude = -73.1019991998 },
new Place { Code = "68425", IsoCode = "68425", Name = "MACARAVITA - SANTANDER", Latitude = 6.50676798489, Longitude = -72.593288878 },
new Place { Code = "68432", IsoCode = "68432", Name = "MÁLAGA - SANTANDER", Latitude = 6.7021775212, Longitude = -72.732133306 },
new Place { Code = "68444", IsoCode = "68444", Name = "MATANZA - SANTANDER", Latitude = 7.32284372116, Longitude = -73.0160819321 },
new Place { Code = "68464", IsoCode = "68464", Name = "MOGOTES - SANTANDER", Latitude = 6.47538726902, Longitude = -72.9704622901 },
new Place { Code = "68468", IsoCode = "68468", Name = "MOLAGAVITA - SANTANDER", Latitude = 6.67384550984, Longitude = -72.8090316759 },
new Place { Code = "68498", IsoCode = "68498", Name = "OCAMONTE - SANTANDER", Latitude = 6.34033572084, Longitude = -73.1220464417 },
new Place { Code = "68500", IsoCode = "68500", Name = "OIBA - SANTANDER", Latitude = 6.26704785206, Longitude = -73.3000340004 },
new Place { Code = "68502", IsoCode = "68502", Name = "ONZAGA - SANTANDER", Latitude = 6.34461189765, Longitude = -72.8139310472 },
new Place { Code = "68522", IsoCode = "68522", Name = "PALMAR - SANTANDER", Latitude = 6.53793539808, Longitude = -73.2911184755 },
new Place { Code = "68524", IsoCode = "68524", Name = "PALMAS DEL SOCORRO - SANTANDER", Latitude = 6.40592838695, Longitude = -73.2879527096 },
new Place { Code = "68533", IsoCode = "68533", Name = "PÁRAMO - SANTANDER", Latitude = 6.41653497873, Longitude = -73.1702915815 },
new Place { Code = "68547", IsoCode = "68547", Name = "PIEDECUESTA - SANTANDER", Latitude = 6.99547484173, Longitude = -73.0543082606 },
new Place { Code = "68549", IsoCode = "68549", Name = "PINCHOTE - SANTANDER", Latitude = 6.53303594661, Longitude = -73.1724561231 },
new Place { Code = "68572", IsoCode = "68572", Name = "PUENTE NACIONAL - SANTANDER", Latitude = 5.87819149232, Longitude = -73.6775097519 },
new Place { Code = "68573", IsoCode = "68573", Name = "PUERTO PARRA - SANTANDER", Latitude = 6.65096788251, Longitude = -74.0588684307 },
new Place { Code = "68575", IsoCode = "68575", Name = "PUERTO WILCHES - SANTANDER", Latitude = 7.34937400169, Longitude = -73.8981286072 },
new Place { Code = "68615", IsoCode = "68615", Name = "RIONEGRO - SANTANDER", Latitude = 7.26321364374, Longitude = -73.1490442944 },
new Place { Code = "68655", IsoCode = "68655", Name = "SABANA DE TORRES - SANTANDER", Latitude = 7.39517157701, Longitude = -73.4983457764 },
new Place { Code = "68669", IsoCode = "68669", Name = "SAN ANDRÉS - SANTANDER", Latitude = 6.81027206166, Longitude = -72.8505851614 },
new Place { Code = "68673", IsoCode = "68673", Name = "SAN BENITO - SANTANDER", Latitude = 6.1266069813, Longitude = -73.509474163 },
new Place { Code = "68679", IsoCode = "68679", Name = "SAN GIL - SANTANDER", Latitude = 6.54927262478, Longitude = -73.1285702201 },
new Place { Code = "68682", IsoCode = "68682", Name = "SAN JOAQUÍN - SANTANDER", Latitude = 6.42754903664, Longitude = -72.8677032526 },
new Place { Code = "68684", IsoCode = "68684", Name = "SAN JOSÉ DE MIRANDA - SANTANDER", Latitude = 6.65866422031, Longitude = -72.7333821183 },
new Place { Code = "68686", IsoCode = "68686", Name = "SAN MIGUEL - SANTANDER", Latitude = 6.57664344984, Longitude = -72.646501116 },
new Place { Code = "68689", IsoCode = "68689", Name = "SAN VICENTE DE CHUCURÍ - SANTANDER", Latitude = 6.87981334011, Longitude = -73.4100182808 },
new Place { Code = "68705", IsoCode = "68705", Name = "SANTA BÁRBARA - SANTANDER", Latitude = 6.99054129659, Longitude = -72.9066829394 },
new Place { Code = "68720", IsoCode = "68720", Name = "SANTA HELENA DEL OPÓN - SANTANDER", Latitude = 6.33839249402, Longitude = -73.6159066537 },
new Place { Code = "68745", IsoCode = "68745", Name = "SIMACOTA - SANTANDER", Latitude = 6.44347223669, Longitude = -73.3374093333 },
new Place { Code = "68755", IsoCode = "68755", Name = "SOCORRO - SANTANDER", Latitude = 6.46369097452, Longitude = -73.2611309592 },
new Place { Code = "68770", IsoCode = "68770", Name = "SUAITA - SANTANDER", Latitude = 6.09835314273, Longitude = -73.4403162236 },
new Place { Code = "68773", IsoCode = "68773", Name = "SUCRE - SANTANDER", Latitude = 5.91903257843, Longitude = -73.7914904516 },
new Place { Code = "68780", IsoCode = "68780", Name = "SURATÁ - SANTANDER", Latitude = 7.36717155542, Longitude = -72.9842771975 },
new Place { Code = "68820", IsoCode = "68820", Name = "TONA - SANTANDER", Latitude = 7.1995257908, Longitude = -72.9682572651 },
new Place { Code = "68855", IsoCode = "68855", Name = "VALLE DE SAN JOSÉ - SANTANDER", Latitude = 6.44800947449, Longitude = -73.1435767141 },
new Place { Code = "68861", IsoCode = "68861", Name = "VÉLEZ - SANTANDER", Latitude = 6.00758055992, Longitude = -73.6745204194 },
new Place { Code = "68867", IsoCode = "68867", Name = "VETAS - SANTANDER", Latitude = 7.30938136063, Longitude = -72.8707413209 },
new Place { Code = "68872", IsoCode = "68872", Name = "VILLANUEVA - SANTANDER", Latitude = 6.66929215486, Longitude = -73.1735022672 },
new Place { Code = "68895", IsoCode = "68895", Name = "ZAPATOCA - SANTANDER", Latitude = 6.81384406691, Longitude = -73.2708555059 },
new Place { Code = "70001", IsoCode = "70001", Name = "SINCELEJO - SUCRE", Latitude = 9.30015762595, Longitude = -75.385219416 },
new Place { Code = "70110", IsoCode = "70110", Name = "BUENAVISTA - SUCRE", Latitude = 9.32003655948, Longitude = -74.9728890971 },
new Place { Code = "70124", IsoCode = "70124", Name = "CAIMITO - SUCRE", Latitude = 8.78902510273, Longitude = -75.1160890758 },
new Place { Code = "70204", IsoCode = "70204", Name = "COLOSÓ - SUCRE", Latitude = 9.49094661829, Longitude = -75.3557164394 },
new Place { Code = "70215", IsoCode = "70215", Name = "COROZAL - SUCRE", Latitude = 9.32068414479, Longitude = -75.2920234071 },
new Place { Code = "70221", IsoCode = "70221", Name = "COVEÑAS - SUCRE", Latitude = 9.40979035049, Longitude = -75.6595981401 },
new Place { Code = "70230", IsoCode = "70230", Name = "CHALÁN - SUCRE", Latitude = 9.54585280105, Longitude = -75.3127962903 },
new Place { Code = "70233", IsoCode = "70233", Name = "EL ROBLE - SUCRE", Latitude = 9.10715240511, Longitude = -75.1940457847 },
new Place { Code = "70235", IsoCode = "70235", Name = "GALERAS - SUCRE", Latitude = 9.15980328043, Longitude = -75.0493364928 },
new Place { Code = "70265", IsoCode = "70265", Name = "GUARANDA - SUCRE", Latitude = 8.46904787457, Longitude = -74.5364152944 },
new Place { Code = "70400", IsoCode = "70400", Name = "LA UNIÓN - SUCRE", Latitude = 8.85112740103, Longitude = -75.2862132605 },
new Place { Code = "70418", IsoCode = "70418", Name = "LOS PALMITOS - SUCRE", Latitude = 9.3801770601, Longitude = -75.26813259 },
new Place { Code = "70429", IsoCode = "70429", Name = "MAJAGUAL - SUCRE", Latitude = 8.54298963226, Longitude = -74.6278933714 },
new Place { Code = "70473", IsoCode = "70473", Name = "MORROA - SUCRE", Latitude = 9.32892494265, Longitude = -75.3103986052 },
new Place { Code = "70508", IsoCode = "70508", Name = "OVEJAS - SUCRE", Latitude = 9.52598596406, Longitude = -75.2288076868 },
new Place { Code = "70523", IsoCode = "70523", Name = "PALMITO - SUCRE", Latitude = 9.33314405737, Longitude = -75.5411703965 },
new Place { Code = "70670", IsoCode = "70670", Name = "SAMPUÉS - SUCRE", Latitude = 9.1824393291, Longitude = -75.379179641 },
new Place { Code = "70678", IsoCode = "70678", Name = "SAN BENITO ABAD - SUCRE", Latitude = 8.92992440782, Longitude = -75.0313690338 },
new Place { Code = "70702", IsoCode = "70702", Name = "SAN JUAN DE BETULIA - SUCRE", Latitude = 9.27457243391, Longitude = -75.2429969111 },
new Place { Code = "70708", IsoCode = "70708", Name = "SAN MARCOS - SUCRE", Latitude = 8.66403584689, Longitude = -75.1390223232 },
new Place { Code = "70713", IsoCode = "70713", Name = "SAN ONOFRE - SUCRE", Latitude = 9.73339187649, Longitude = -75.530327312 },
new Place { Code = "70717", IsoCode = "70717", Name = "SAN PEDRO - SUCRE", Latitude = 9.39608379513, Longitude = -75.0637558144 },
new Place { Code = "70742", IsoCode = "70742", Name = "SAN LUIS DE SINCÉ - SUCRE", Latitude = 9.24448244293, Longitude = -75.1466720381 },
new Place { Code = "70771", IsoCode = "70771", Name = "SUCRE - SUCRE", Latitude = 8.81357258088, Longitude = -74.7220666388 },
new Place { Code = "70820", IsoCode = "70820", Name = "SANTIAGO DE TOLÚ - SUCRE", Latitude = 9.50881495881, Longitude = -75.5881183393 },
new Place { Code = "70823", IsoCode = "70823", Name = "TOLÚ VIEJO - SUCRE", Latitude = 9.45318799461, Longitude = -75.4395557882 },
new Place { Code = "73001", IsoCode = "73001", Name = "IBAGUÉ - TOLIMA", Latitude = 4.4396307255, Longitude = -75.1963501468 },
new Place { Code = "73024", IsoCode = "73024", Name = "ALPUJARRA - TOLIMA", Latitude = 3.39179995739, Longitude = -74.9325662896 },
new Place { Code = "73026", IsoCode = "73026", Name = "ALVARADO - TOLIMA", Latitude = 4.56816462109, Longitude = -74.9521517538 },
new Place { Code = "73030", IsoCode = "73030", Name = "AMBALEMA - TOLIMA", Latitude = 4.78538612936, Longitude = -74.7617986138 },
new Place { Code = "73043", IsoCode = "73043", Name = "ANZOÁTEGUI - TOLIMA", Latitude = 4.63284669704, Longitude = -75.0932838261 },
new Place { Code = "73055", IsoCode = "73055", Name = "ARMERO GUAYABAL - TOLIMA", Latitude = 5.02900045806, Longitude = -74.884169344 },
new Place { Code = "73067", IsoCode = "73067", Name = "ATACO - TOLIMA", Latitude = 3.5911648673, Longitude = -75.3824540225 },
new Place { Code = "73124", IsoCode = "73124", Name = "CAJAMARCA - TOLIMA", Latitude = 4.43777027275, Longitude = -75.4337958576 },
new Place { Code = "73148", IsoCode = "73148", Name = "CARMEN DE APICALÁ - TOLIMA", Latitude = 4.14664309207, Longitude = -74.7233312429 },
new Place { Code = "73152", IsoCode = "73152", Name = "CASABIANCA - TOLIMA", Latitude = 5.07914791303, Longitude = -75.1197910712 },
new Place { Code = "73168", IsoCode = "73168", Name = "CHAPARRAL - TOLIMA", Latitude = 3.72576111019, Longitude = -75.4835822098 },
new Place { Code = "73200", IsoCode = "73200", Name = "COELLO - TOLIMA", Latitude = 4.28612891105, Longitude = -74.8978955326 },
new Place { Code = "73217", IsoCode = "73217", Name = "COYAIMA - TOLIMA", Latitude = 3.79872369111, Longitude = -75.1962077778 },
new Place { Code = "73226", IsoCode = "73226", Name = "CUNDAY - TOLIMA", Latitude = 4.05974687946, Longitude = -74.6932717766 },
new Place { Code = "73236", IsoCode = "73236", Name = "DOLORES - TOLIMA", Latitude = 3.53844375037, Longitude = -74.8974337106 },
new Place { Code = "73268", IsoCode = "73268", Name = "ESPINAL - TOLIMA", Latitude = 4.15071173193, Longitude = -74.8842257807 },
new Place { Code = "73270", IsoCode = "73270", Name = "FALAN - TOLIMA", Latitude = 5.11932413169, Longitude = -74.955500479 },
new Place { Code = "73275", IsoCode = "73275", Name = "FLANDES - TOLIMA", Latitude = 4.28279453042, Longitude = -74.8105553573 },
new Place { Code = "73283", IsoCode = "73283", Name = "FRESNO - TOLIMA", Latitude = 5.15358768839, Longitude = -75.0361949825 },
new Place { Code = "73319", IsoCode = "73319", Name = "GUAMO - TOLIMA", Latitude = 4.02995546446, Longitude = -74.9714950458 },
new Place { Code = "73347", IsoCode = "73347", Name = "HERVEO - TOLIMA", Latitude = 5.07994522497, Longitude = -75.1782250336 },
new Place { Code = "73349", IsoCode = "73349", Name = "HONDA - TOLIMA", Latitude = 5.20098204315, Longitude = -74.7417614867 },
new Place { Code = "73352", IsoCode = "73352", Name = "ICONONZO - TOLIMA", Latitude = 4.17413014301, Longitude = -74.5279984191 },
new Place { Code = "73408", IsoCode = "73408", Name = "LÉRIDA - TOLIMA", Latitude = 4.86105174121, Longitude = -74.9116022877 },
new Place { Code = "73411", IsoCode = "73411", Name = "LÍBANO - TOLIMA", Latitude = 4.91611360304, Longitude = -75.0532201721 },
new Place { Code = "73443", IsoCode = "73443", Name = "SAN SEBASTIÁN DE MARIQUITA - TOLIMA", Latitude = 5.20016963007, Longitude = -74.8893354654 },
new Place { Code = "73449", IsoCode = "73449", Name = "MELGAR - TOLIMA", Latitude = 4.20542800178, Longitude = -74.6269661858 },
new Place { Code = "73461", IsoCode = "73461", Name = "MURILLO - TOLIMA", Latitude = 4.87540969341, Longitude = -75.1703186573 },
new Place { Code = "73483", IsoCode = "73483", Name = "NATAGAIMA - TOLIMA", Latitude = 3.62051386577, Longitude = -75.0905960235 },
new Place { Code = "73504", IsoCode = "73504", Name = "ORTEGA - TOLIMA", Latitude = 3.93505594095, Longitude = -75.2207941366 },
new Place { Code = "73520", IsoCode = "73520", Name = "PALOCABILDO - TOLIMA", Latitude = 5.12048013515, Longitude = -75.0233432328 },
new Place { Code = "73547", IsoCode = "73547", Name = "PIEDRAS - TOLIMA", Latitude = 4.54450576723, Longitude = -74.8765096607 },
new Place { Code = "73555", IsoCode = "73555", Name = "PLANADAS - TOLIMA", Latitude = 3.19702137702, Longitude = -75.6437838795 },
new Place { Code = "73563", IsoCode = "73563", Name = "PRADO - TOLIMA", Latitude = 3.74982800963, Longitude = -74.927275778 },
new Place { Code = "73585", IsoCode = "73585", Name = "PURIFICACIÓN - TOLIMA", Latitude = 3.86033814253, Longitude = -74.9266266553 },
new Place { Code = "73616", IsoCode = "73616", Name = "RIOBLANCO - TOLIMA", Latitude = 3.53021377748, Longitude = -75.6446841365 },
new Place { Code = "73622", IsoCode = "73622", Name = "RONCESVALLES - TOLIMA", Latitude = 4.0112275185, Longitude = -75.606139052 },
new Place { Code = "73624", IsoCode = "73624", Name = "ROVIRA - TOLIMA", Latitude = 4.23948330632, Longitude = -75.2406831254 },
new Place { Code = "73671", IsoCode = "73671", Name = "SALDAÑA - TOLIMA", Latitude = 3.92679713246, Longitude = -75.016636739 },
new Place { Code = "73675", IsoCode = "73675", Name = "SAN ANTONIO - TOLIMA", Latitude = 3.91585542943, Longitude = -75.4771786037 },
new Place { Code = "73678", IsoCode = "73678", Name = "SAN LUIS - TOLIMA", Latitude = 4.13388114891, Longitude = -75.0958703911 },
new Place { Code = "73686", IsoCode = "73686", Name = "SANTA ISABEL - TOLIMA", Latitude = 4.71380797974, Longitude = -75.0946715077 },
new Place { Code = "73770", IsoCode = "73770", Name = "SUÁREZ - TOLIMA", Latitude = 4.04759975319, Longitude = -74.8318168564 },
new Place { Code = "73854", IsoCode = "73854", Name = "VALLE DE SAN JUAN - TOLIMA", Latitude = 4.19748503246, Longitude = -75.1155895489 },
new Place { Code = "73861", IsoCode = "73861", Name = "VENADILLO - TOLIMA", Latitude = 4.71677806822, Longitude = -74.9293838114 },
new Place { Code = "73870", IsoCode = "73870", Name = "VILLAHERMOSA - TOLIMA", Latitude = 5.03029544523, Longitude = -75.117789876 },
new Place { Code = "73873", IsoCode = "73873", Name = "VILLARRICA - TOLIMA", Latitude = 3.93692155457, Longitude = -74.6005986903 },
new Place { Code = "76001", IsoCode = "76001", Name = "CALI - VALLE DEL CAUCA", Latitude = 3.40638218413, Longitude = -76.5263911952 },
new Place { Code = "76020", IsoCode = "76020", Name = "ALCALÁ - VALLE DEL CAUCA", Latitude = 4.67394189929, Longitude = -75.7756614608 },
new Place { Code = "76036", IsoCode = "76036", Name = "ANDALUCÍA - VALLE DEL CAUCA", Latitude = 4.17671561529, Longitude = -76.164666371 },
new Place { Code = "76041", IsoCode = "76041", Name = "ANSERMANUEVO - VALLE DEL CAUCA", Latitude = 4.79322314547, Longitude = -75.9916051896 },
new Place { Code = "76054", IsoCode = "76054", Name = "ARGELIA - VALLE DEL CAUCA", Latitude = 4.72685117123, Longitude = -76.1219607073 },
new Place { Code = "76100", IsoCode = "76100", Name = "BOLÍVAR - VALLE DEL CAUCA", Latitude = 4.33813737568, Longitude = -76.184963255 },
new Place { Code = "76109", IsoCode = "76109", Name = "BUENAVENTURA - VALLE DEL CAUCA", Latitude = 3.8736635476, Longitude = -77.020565216 },
new Place { Code = "76111", IsoCode = "76111", Name = "GUADALAJARA DE BUGA - VALLE DEL CAUCA", Latitude = 3.90140102727, Longitude = -76.298934041 },
new Place { Code = "76113", IsoCode = "76113", Name = "BUGALAGRANDE - VALLE DEL CAUCA", Latitude = 4.20815303943, Longitude = -76.157715207 },
new Place { Code = "76122", IsoCode = "76122", Name = "CAICEDONIA - VALLE DEL CAUCA", Latitude = 4.34062227774, Longitude = -75.8365343901 },
new Place { Code = "76126", IsoCode = "76126", Name = "CALIMA - VALLE DEL CAUCA", Latitude = 3.93522394764, Longitude = -76.4842233721 },
new Place { Code = "76130", IsoCode = "76130", Name = "CANDELARIA - VALLE DEL CAUCA", Latitude = 3.40934946242, Longitude = -76.3477358517 },
new Place { Code = "76147", IsoCode = "76147", Name = "CARTAGO - VALLE DEL CAUCA", Latitude = 4.73852191576, Longitude = -75.911513294 },
new Place { Code = "76233", IsoCode = "76233", Name = "DAGUA - VALLE DEL CAUCA", Latitude = 3.65739350075, Longitude = -76.6891747623 },
new Place { Code = "76243", IsoCode = "76243", Name = "EL ÁGUILA - VALLE DEL CAUCA", Latitude = 4.9098804712, Longitude = -76.0413378052 },
new Place { Code = "76246", IsoCode = "76246", Name = "EL CAIRO - VALLE DEL CAUCA", Latitude = 4.75849388321, Longitude = -76.2234172512 },
new Place { Code = "76248", IsoCode = "76248", Name = "EL CERRITO - VALLE DEL CAUCA", Latitude = 3.68475027511, Longitude = -76.3117340825 },
new Place { Code = "76250", IsoCode = "76250", Name = "EL DOVIO - VALLE DEL CAUCA", Latitude = 4.50991498952, Longitude = -76.2372660275 },
new Place { Code = "76275", IsoCode = "76275", Name = "FLORIDA - VALLE DEL CAUCA", Latitude = 3.32440450257, Longitude = -76.2347321504 },
new Place { Code = "76306", IsoCode = "76306", Name = "GINEBRA - VALLE DEL CAUCA", Latitude = 3.72490001451, Longitude = -76.2688695408 },
new Place { Code = "76318", IsoCode = "76318", Name = "GUACARÍ - VALLE DEL CAUCA", Latitude = 3.76199549423, Longitude = -76.3335063129 },
new Place { Code = "76364", IsoCode = "76364", Name = "JAMUNDÍ - VALLE DEL CAUCA", Latitude = 3.26418634132, Longitude = -76.5388095508 },
new Place { Code = "76377", IsoCode = "76377", Name = "LA CUMBRE - VALLE DEL CAUCA", Latitude = 3.64718929344, Longitude = -76.5681664632 },
new Place { Code = "76400", IsoCode = "76400", Name = "LA UNIÓN - VALLE DEL CAUCA", Latitude = 4.5329582406, Longitude = -76.1031721653 },
new Place { Code = "76403", IsoCode = "76403", Name = "LA VICTORIA - VALLE DEL CAUCA", Latitude = 4.52444084112, Longitude = -76.0362142089 },
new Place { Code = "76497", IsoCode = "76497", Name = "OBANDO - VALLE DEL CAUCA", Latitude = 4.57493085648, Longitude = -75.9747307562 },
new Place { Code = "76520", IsoCode = "76520", Name = "PALMIRA - VALLE DEL CAUCA", Latitude = 3.53293733103, Longitude = -76.29821561 },
new Place { Code = "76563", IsoCode = "76563", Name = "PRADERA - VALLE DEL CAUCA", Latitude = 3.4194377673, Longitude = -76.2410411119 },
new Place { Code = "76606", IsoCode = "76606", Name = "RESTREPO - VALLE DEL CAUCA", Latitude = 3.82289988625, Longitude = -76.5250791446 },
new Place { Code = "76616", IsoCode = "76616", Name = "RIOFRÍO - VALLE DEL CAUCA", Latitude = 4.1574581031, Longitude = -76.2906271153 },
new Place { Code = "76622", IsoCode = "76622", Name = "ROLDANILLO - VALLE DEL CAUCA", Latitude = 4.4135483937, Longitude = -76.1510315894 },
new Place { Code = "76670", IsoCode = "76670", Name = "SAN PEDRO - VALLE DEL CAUCA", Latitude = 3.99415724449, Longitude = -76.229433837 },
new Place { Code = "76736", IsoCode = "76736", Name = "SEVILLA - VALLE DEL CAUCA", Latitude = 4.26719134689, Longitude = -75.9311573268 },
new Place { Code = "76823", IsoCode = "76823", Name = "TORO - VALLE DEL CAUCA", Latitude = 4.60848895439, Longitude = -76.0784077771 },
new Place { Code = "76828", IsoCode = "76828", Name = "TRUJILLO - VALLE DEL CAUCA", Latitude = 4.20933453331, Longitude = -76.3216244643 },
new Place { Code = "76834", IsoCode = "76834", Name = "TULUÁ - VALLE DEL CAUCA", Latitude = 4.08535846473, Longitude = -76.1971756038 },
new Place { Code = "76845", IsoCode = "76845", Name = "ULLOA - VALLE DEL CAUCA", Latitude = 4.70286142582, Longitude = -75.7387552282 },
new Place { Code = "76863", IsoCode = "76863", Name = "VERSALLES - VALLE DEL CAUCA", Latitude = 4.57582061586, Longitude = -76.1995094028 },
new Place { Code = "76869", IsoCode = "76869", Name = "VIJES - VALLE DEL CAUCA", Latitude = 3.69710442625, Longitude = -76.4384865057 },
new Place { Code = "76890", IsoCode = "76890", Name = "YOTOCO - VALLE DEL CAUCA", Latitude = 3.86106676244, Longitude = -76.3830866804 },
new Place { Code = "76892", IsoCode = "76892", Name = "YUMBO - VALLE DEL CAUCA", Latitude = 3.54053354875, Longitude = -76.4976116712 },
new Place { Code = "76895", IsoCode = "76895", Name = "ZARZAL - VALLE DEL CAUCA", Latitude = 4.39042846549, Longitude = -76.0717481661 },
new Place { Code = "81001", IsoCode = "81001", Name = "ARAUCA - ARAUCA", Latitude = 7.07773650197, Longitude = -70.762773048 },
new Place { Code = "81065", IsoCode = "81065", Name = "ARAUQUITA - ARAUCA", Latitude = 7.02931365346, Longitude = -71.4276395909 },
new Place { Code = "81220", IsoCode = "81220", Name = "CRAVO NORTE - ARAUCA", Latitude = 6.30339369864, Longitude = -70.2035675603 },
new Place { Code = "81300", IsoCode = "81300", Name = "FORTUL - ARAUCA", Latitude = 6.79925590284, Longitude = -71.7678607445 },
new Place { Code = "81591", IsoCode = "81591", Name = "PUERTO RONDÓN - ARAUCA", Latitude = 6.27986338565, Longitude = -71.1030694296 },
new Place { Code = "81736", IsoCode = "81736", Name = "SARAVENA - ARAUCA", Latitude = 6.95387794066, Longitude = -71.8739494778 },
new Place { Code = "81794", IsoCode = "81794", Name = "TAME - ARAUCA", Latitude = 6.45653811474, Longitude = -71.7436532635 },
new Place { Code = "85001", IsoCode = "85001", Name = "YOPAL - CASANARE", Latitude = 5.33249117563, Longitude = -72.3937905332 },
new Place { Code = "85010", IsoCode = "85010", Name = "AGUAZUL - CASANARE", Latitude = 5.16998543064, Longitude = -72.5525853378 },
new Place { Code = "85015", IsoCode = "85015", Name = "CHÁMEZA - CASANARE", Latitude = 5.21462671788, Longitude = -72.8698899916 },
new Place { Code = "85125", IsoCode = "85125", Name = "HATO COROZAL - CASANARE", Latitude = 6.15639181167, Longitude = -71.7646275436 },
new Place { Code = "85136", IsoCode = "85136", Name = "LA SALINA - CASANARE", Latitude = 6.1278203601, Longitude = -72.3339677886 },
new Place { Code = "85139", IsoCode = "85139", Name = "MANÍ - CASANARE", Latitude = 4.81684480839, Longitude = -72.2801607687 },
new Place { Code = "85162", IsoCode = "85162", Name = "MONTERREY - CASANARE", Latitude = 4.87941196756, Longitude = -72.8890956447 },
new Place { Code = "85225", IsoCode = "85225", Name = "NUNCHÍA - CASANARE", Latitude = 5.63712937413, Longitude = -72.1953826495 },
new Place { Code = "85230", IsoCode = "85230", Name = "OROCUÉ - CASANARE", Latitude = 4.79003391817, Longitude = -71.3381053762 },
new Place { Code = "85250", IsoCode = "85250", Name = "PAZ DE ARIPORO - CASANARE", Latitude = 5.88140262363, Longitude = -71.8917286791 },
new Place { Code = "85263", IsoCode = "85263", Name = "PORE - CASANARE", Latitude = 5.72676620203, Longitude = -71.9923928081 },
new Place { Code = "85279", IsoCode = "85279", Name = "RECETOR - CASANARE", Latitude = 5.22914827753, Longitude = -72.7609072187 },
new Place { Code = "85300", IsoCode = "85300", Name = "SABANALARGA - CASANARE", Latitude = 4.853360442, Longitude = -73.0391757446 },
new Place { Code = "85315", IsoCode = "85315", Name = "SÁCAMA - CASANARE", Latitude = 6.09789911488, Longitude = -72.2488935738 },
new Place { Code = "85325", IsoCode = "85325", Name = "SAN LUIS DE PALENQUE - CASANARE", Latitude = 5.4218395761, Longitude = -71.7312298874 },
new Place { Code = "85400", IsoCode = "85400", Name = "TÁMARA - CASANARE", Latitude = 5.82909664859, Longitude = -72.1642249065 },
new Place { Code = "85410", IsoCode = "85410", Name = "TAURAMENA - CASANARE", Latitude = 5.01312278938, Longitude = -72.7477361123 },
new Place { Code = "85430", IsoCode = "85430", Name = "TRINIDAD - CASANARE", Latitude = 5.41101622376, Longitude = -71.6626786509 },
new Place { Code = "85440", IsoCode = "85440", Name = "VILLANUEVA - CASANARE", Latitude = 4.6098209635, Longitude = -72.9290192773 },
new Place { Code = "86001", IsoCode = "86001", Name = "MOCOA - PUTUMAYO", Latitude = 1.14428450756, Longitude = -76.6519175009 },
new Place { Code = "86219", IsoCode = "86219", Name = "COLÓN - PUTUMAYO", Latitude = 1.19200057658, Longitude = -76.9689800339 },
new Place { Code = "86320", IsoCode = "86320", Name = "ORITO - PUTUMAYO", Latitude = 0.676020477109, Longitude = -76.8802098557 },
new Place { Code = "86568", IsoCode = "86568", Name = "PUERTO ASÍS - PUTUMAYO", Latitude = 0.504218750676, Longitude = -76.4978366718 },
new Place { Code = "86569", IsoCode = "86569", Name = "PUERTO CAICEDO - PUTUMAYO", Latitude = 0.685064178774, Longitude = -76.6045178173 },
new Place { Code = "86571", IsoCode = "86571", Name = "PUERTO GUZMÁN - PUTUMAYO", Latitude = 0.963896881051, Longitude = -76.4080321934 },
new Place { Code = "86573", IsoCode = "86573", Name = "PUERTO LEGUÍZAMO - PUTUMAYO", Latitude = -0.184973168422, Longitude = -74.7836699476 },
new Place { Code = "86749", IsoCode = "86749", Name = "SIBUNDOY - PUTUMAYO", Latitude = 1.2030862151, Longitude = -76.9212871804 },
new Place { Code = "86755", IsoCode = "86755", Name = "SAN FRANCISCO - PUTUMAYO", Latitude = 1.17674026489, Longitude = -76.875892028 },
new Place { Code = "86757", IsoCode = "86757", Name = "SAN MIGUEL - PUTUMAYO", Latitude = 0.273017004162, Longitude = -76.8453432762 },
new Place { Code = "86760", IsoCode = "86760", Name = "SANTIAGO - PUTUMAYO", Latitude = 1.1465700937, Longitude = -77.0025114068 },
new Place { Code = "86865", IsoCode = "86865", Name = "VALLE DEL GUAMUEZ - PUTUMAYO", Latitude = 0.423905142192, Longitude = -76.9050395058 },
new Place { Code = "86885", IsoCode = "86885", Name = "VILLAGARZÓN - PUTUMAYO", Latitude = 1.02995420604, Longitude = -76.6168096886 },
new Place { Code = "88001", IsoCode = "88001", Name = "SAN ANDRÉS - ARCHIPIÉLAGO DE SAN ANDRÉS Y PROVIDENCIA", Latitude = 12.5829884179, Longitude = -81.6960414806 },
new Place { Code = "88564", IsoCode = "88564", Name = "PROVIDENCIA - ARCHIPIÉLAGO DE SAN ANDRÉS Y PROVIDENCIA", Latitude = 13.3701242163, Longitude = -81.3709091411 },
new Place { Code = "91001", IsoCode = "91001", Name = "LETICIA - AMAZONAS", Latitude = -4.21202316969, Longitude = -69.9406798289 },
new Place { Code = "91263", IsoCode = "91263", Name = "EL ENCANTO - AMAZONAS", Latitude = -2.0086230627875, Longitude = -72.724005861231 },
new Place { Code = "91405", IsoCode = "91405", Name = "LA CHORRERA - AMAZONAS", Latitude = -1.2423641464413, Longitude = -72.7588253369472 },
new Place { Code = "91407", IsoCode = "91407", Name = "LA PEDRERA - AMAZONAS", Latitude = -1.4323734428449, Longitude = -70.035395399943 },
new Place { Code = "91430", IsoCode = "91430", Name = "LA VICTORIA - AMAZONAS", Latitude = -0.1121161118131, Longitude = -71.1305321686724 },
new Place { Code = "91460", IsoCode = "91460", Name = "MIRITÍ - PARANÁ - AMAZONAS", Latitude = -0.6853635412458, Longitude = -71.1859126619389 },
new Place { Code = "91530", IsoCode = "91530", Name = "PUERTO ALEGRÍA - AMAZONAS", Latitude = -0.9688578690868, Longitude = -73.7496853632398 },
new Place { Code = "91536", IsoCode = "91536", Name = "PUERTO ARICA - AMAZONAS", Latitude = -1.9067899296578, Longitude = -71.1465318828448 },
new Place { Code = "91540", IsoCode = "91540", Name = "PUERTO NARIÑO - AMAZONAS", Latitude = -3.7899163029, Longitude = -70.3564801394 },
new Place { Code = "91669", IsoCode = "91669", Name = "PUERTO SANTANDER - AMAZONAS", Latitude = -1.0986758956768, Longitude = -71.939286893897 },
new Place { Code = "91798", IsoCode = "91798", Name = "TARAPACÁ - AMAZONAS", Latitude = -2.4594107942004, Longitude = -70.0016249985574 },
new Place { Code = "94001", IsoCode = "94001", Name = "INÍRIDA - GUAINÍA", Latitude = 3.87032554774, Longitude = -67.918283684 },
new Place { Code = "94343", IsoCode = "94343", Name = "BARRANCO MINAS - GUAINÍA", Latitude = 3.3112513780573, Longitude = -69.3969861532774 },
new Place { Code = "94663", IsoCode = "94663", Name = "MAPIRIPANA - GUAINÍA", Latitude = 2.8100146429346, Longitude = -70.2857520406271 },
new Place { Code = "94883", IsoCode = "94883", Name = "SAN FELIPE - GUAINÍA", Latitude = 2.1219380615422, Longitude = -67.3449045561149 },
new Place { Code = "94884", IsoCode = "94884", Name = "PUERTO COLOMBIA - GUAINÍA", Latitude = 2.5051112207453, Longitude = -68.2120702083237 },
new Place { Code = "94885", IsoCode = "94885", Name = "LA GUADALUPE - GUAINÍA", Latitude = 1.369705812022, Longitude = -67.006766761495 },
new Place { Code = "94886", IsoCode = "94886", Name = "CACAHUAL - GUAINÍA", Latitude = 3.3838520898148, Longitude = -67.5828556335348 },
new Place { Code = "94887", IsoCode = "94887", Name = "PANA PANA - GUAINÍA", Latitude = 1.9753587012478, Longitude = -69.1199556912911 },
new Place { Code = "94888", IsoCode = "94888", Name = "MORICHAL - GUAINÍA", Latitude = 2.4298105273994, Longitude = -69.8328621676151 },
new Place { Code = "95001", IsoCode = "95001", Name = "SAN JOSÉ DEL GUAVIARE - GUAVIARE", Latitude = 2.57047809895, Longitude = -72.6400959977 },
new Place { Code = "95015", IsoCode = "95015", Name = "CALAMAR - GUAVIARE", Latitude = 1.95858583781, Longitude = -72.6549595115 },
new Place { Code = "95025", IsoCode = "95025", Name = "EL RETORNO - GUAVIARE", Latitude = 2.33079719736, Longitude = -72.6279707884 },
new Place { Code = "95200", IsoCode = "95200", Name = "MIRAFLORES - GUAVIARE", Latitude = 1.33679172984, Longitude = -71.9512603081 },
new Place { Code = "97001", IsoCode = "97001", Name = "MITÚ - VAUPÉS", Latitude = 1.25117078854, Longitude = -70.2349602618 },
new Place { Code = "97161", IsoCode = "97161", Name = "CARURÚ - VAUPÉS", Latitude = 1.01130519127, Longitude = -71.2936075006 },
new Place { Code = "97511", IsoCode = "97511", Name = "PACOA - VAUPÉS", Latitude = 0.1814999263078, Longitude = -70.9101348992581 },
new Place { Code = "97666", IsoCode = "97666", Name = "TARAIRA - VAUPÉS", Latitude = -0.564700181703, Longitude = -69.6340537503 },
new Place { Code = "97777", IsoCode = "97777", Name = "PAPUNAUA - VAUPÉS", Latitude = 1.6834278531963, Longitude = -70.7097021915482 },
new Place { Code = "97889", IsoCode = "97889", Name = "YAVARATÉ - VAUPÉS", Latitude = 0.8280222426218, Longitude = -69.6159336169572 },
new Place { Code = "99001", IsoCode = "99001", Name = "PUERTO CARREÑO - VICHADA", Latitude = 6.18560656721, Longitude = -67.4855961 },
new Place { Code = "99524", IsoCode = "99524", Name = "LA PRIMAVERA - VICHADA", Latitude = 5.49073733939, Longitude = -70.4130869161 },
new Place { Code = "99624", IsoCode = "99624", Name = "SANTA ROSALÍA - VICHADA", Latitude = 5.13110359416, Longitude = -70.863710818 },
new Place { Code = "99773", IsoCode = "99773", Name = "CUMARIBO - VICHADA", Latitude = 4.44448762209, Longitude = -69.7985426682 }
            );

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
