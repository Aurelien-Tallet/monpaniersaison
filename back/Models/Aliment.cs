namespace back.Models;
using System;
public class Aliment
{
    public static string[] TypeNames = { "Fruit", "Vegetable", "Unknow" };
    public static string[] NutriscoreNames = { "A", "B", "C", "D", "E", "Unknow" };
    public static string[] SeasonNames = { "Winter", "Spring", "Summer", "Autumn" };
    public static string[] CountryNames = { "France", "Germany", "Italy", "Spain", "United Kingdom", "United States" };

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Season { get; set; }
    public string? Type { get; set; }
    public double? Calories { get; set; }
    public string? Nutriscore { get; set; }
    public string? ImageUrl { get; set; }
    public string? Localisation { get; set; }

   // Array of array of strings. Each array is a list of countries where the aliment is found.
     
   private static IDictionary<string, string>? Repository = new Dictionary<string, string>
    {
       {
         "ABRICOT",
         "https://www.leparfait.fr/uploads/media/6436d98ee0c14bd7b4f8c78843f393b4.png"
    },
    {
         "Ail",
         "https://www.leparfait.fr/uploads/media/e2101e41a7bd41aebd50bf2431935718.png"
    },
    {
         "Ail des ours",
         "https://www.leparfait.fr/uploads/media/5f103535d9eed.png"
    },
    {
         "Amande",
         "https://www.leparfait.fr/uploads/media/5f1034b141218.png"
    },
    {
         "Ananas",
         "https://www.leparfait.fr/uploads/media/4ea77e349d27d708d7d4aeb20b07aad7.png"
    },
    {
         "ARTICHAUT",
         "https://www.leparfait.fr/uploads/media/251f6ae10c8d23946b301a29b9ce8d6b.png"
    },
    {
         "Asperge",
         "https://www.leparfait.fr/uploads/media/a965ed5da6ca01a60ca5d1c46bcbf586.png"
    },
    {
         "AUBERGINE",
         "https://www.leparfait.fr/uploads/media/47774a21c7684a877f2a382083b6d2bd.png"
    },
    {
         "Avocat",
         "https://www.leparfait.fr/uploads/media/5f103222973d9.png"
    },
    {
         "BANANE",
         "https://www.leparfait.fr/uploads/media/8cbece7e4ffb1502c212febcb13db409.png"
    },
    {
         "BASILIC",
         "https://www.leparfait.fr/uploads/media/03a587a81be9664d7b5f31afd0a27a46.png"
    },
    {
         "BETTERAVE",
         "https://www.leparfait.fr/uploads/media/5f103233ebb8f.png"
    },
    {
         "BLETTE",
         "https://www.leparfait.fr/uploads/media/5f10324714311.png"
    },
    {
         "BOLET",
         "https://www.leparfait.fr/uploads/media/5f1035cc3f77b.png"
    },
    {
         "BROCOLIS",
         "https://www.leparfait.fr/uploads/media/6c6a85261e2becfc3f17155f6894a129.png"
    },
    {
         "CÂPRE",
         "https://www.leparfait.fr/uploads/media/65f871295107c4eaedeb4489aec7f1f8.png"
    },
    {
         "Carotte",
         "https://www.leparfait.fr/uploads/media/9e85a34eaff43061078afb67befe0528.png"
    },
    {
         "CASSIS",
         "https://www.leparfait.fr/uploads/media/b064c9ac9d7fb3de01565b1d31552ae0.png"
    },
    {
         "Céleri",
         "https://www.leparfait.fr/uploads/media/8efa2439ba2965dd5680ce23847ceedb.png"
    },
    {
         "CÈPE",
         "https://www.leparfait.fr/uploads/media/16066abecd1a2500ec718a9d03084692.png"
    },
    {
         "CERISE",
         "https://www.leparfait.fr/uploads/media/838bb9cec2ce01c18e7d3b6c8ceaa58e.png"
    },
    {
         "CHAMPIGNON DE PARIS",
         "https://www.leparfait.fr/uploads/media/9ab36d60513d710d482cf8de44c60f21.png"
    },
    {
         "Châtaigne",
         "https://www.leparfait.fr/uploads/media/7671f49c98270ae72e535bf159a3d338.png"
    },
    {
         "Chou",
         "https://www.leparfait.fr/uploads/media/f33e644a3da22dbf1884d5520a123c72.png"
    },
    {
         "CHOU BLANC",
         "https://www.leparfait.fr/uploads/media/5f10326973317.png"
    },
    {
         "CHOU CHINOIS",
         "https://www.leparfait.fr/uploads/media/5f22f83d49b01.png"
    },
    {
         "Chou de Bruxelles",
         "https://www.leparfait.fr/uploads/media/5f1032770eacd.png"
    },
    {
         "CHOU RAVE",
         "https://www.leparfait.fr/uploads/media/5f1032cd9961e.png"
    },
    {
         "CHOU ROMANESCO",
         "https://www.leparfait.fr/uploads/media/5f10329bdf876.png"
    },
    {
         "CHOU ROUGE",
         "https://www.leparfait.fr/uploads/media/5f1032ab82b51.png"
    },
    {
         "CHOU-FLEUR",
         "https://www.leparfait.fr/uploads/media/f8af8701985b412a71e35633e8eb097b.png"
    },
    {
         "CITRON JAUNE",
         "https://www.leparfait.fr/uploads/media/8e79a40207a684ce79aa870823a3c564.png"
    },
    {
         "CITRON VERT",
         "https://www.leparfait.fr/uploads/media/f06ed5640a3d6198a3ecdc14ee7f6fc5.png"
    },
    {
         "Citrouille",
         "https://www.leparfait.fr/uploads/media/5f10334671acb.png"
    },
    {
         "Clémentine",
         "https://www.leparfait.fr/uploads/media/5e99958e89643b24b607b2609e8fce54.png"
    },
    {
         "Coing",
         "https://www.leparfait.fr/uploads/media/5f1030f81ffce.png"
    },
    {
         "CONCOMBRE",
         "https://www.leparfait.fr/uploads/media/242489884ca3d836b0eb00bcebd2edaf.png"
    },
    {
         "Coquelicot",
         "https://www.leparfait.fr/uploads/media/5f10351c89594.png"
    },
    {
         "Coulemelle",
         "https://www.leparfait.fr/uploads/media/5f1035ad6629e.png"
    },
    {
         "COURGETTE",
         "https://www.leparfait.fr/uploads/media/8202146abf701394bc5c6729b39aa4f4.png"
    },
    {
         "CRESSON",
         "https://www.leparfait.fr/uploads/media/5f103353b6ad9.png"
    },
    {
         "Cynorrhodons",
         "https://www.leparfait.fr/uploads/media/5f10350c856c2.png"
    },
    {
         "Datte",
         "https://www.leparfait.fr/uploads/media/5f1034a2821b7.png"
    },
    {
         "ECHALOTE",
         "https://www.leparfait.fr/uploads/media/348684bac2f75272a3ec09efb3112b83.png"
    },
    {
         "Endives",
         "https://www.leparfait.fr/uploads/media/5af5dcd99676ca490815b247ba5c38ed.png"
    },
    {
         "EPINARD",
         "https://www.leparfait.fr/uploads/media/fb3667d60e17212bd58dff7871b98c6c.png"
    },
    {
         "FENOUIL",
         "https://www.leparfait.fr/uploads/media/247bd413b5596c88364fd3303f86e701.png"
    },
    {
         "Fève",
         "https://www.leparfait.fr/uploads/media/5b2e0b063aafbe30000a6f2c04eba655.png"
    },
    {
         "FIGUE",
         "https://www.leparfait.fr/uploads/media/ec9682db6cc1ebd0908ac9a2a22ce7eb.png"
    },
    {
         "Fleurs de sureau",
         "https://www.leparfait.fr/uploads/media/5f1034fe1baa7.png"
    },
    {
         "FRAISE",
         "https://www.leparfait.fr/uploads/media/984266655be08f8c782e058d46a95df9.png"
    },
    {
         "Fraise des bois",
         "https://www.leparfait.fr/uploads/media/c02d858e97eee3ea1fe65ed0df422e83.png"
    },
    {
         "FRAMBOISE",
         "https://www.leparfait.fr/uploads/media/f3be3fdf21a028799b87a0fadc01bdc1.png"
    },
    {
         "Fruit de la passion",
         "https://www.leparfait.fr/uploads/media/5f10317e9d185.png"
    },
    {
         "Grenade",
         "https://www.leparfait.fr/uploads/media/5f10318ef3458.png"
    },
    {
         "GROSEILLE",
         "https://www.leparfait.fr/uploads/media/8a68202ea01383096e8ba345f8421f15.png"
    },
    {
         "HARICOT VERT",
         "https://www.leparfait.fr/uploads/media/7edc9448e02b24eacaaf6e76fce62162.png"
    },
    {
         "Kaki",
         "https://www.leparfait.fr/uploads/media/5f10319e4c26c.png"
    },
    {
         "Kiwi",
         "https://www.leparfait.fr/uploads/media/c41a05102778c4206f879acae8c34c32.png"
    },
    {
         "Kumquat",
         "https://www.leparfait.fr/uploads/media/5f1031ac9a2a4.png"
    },
    {
         "LAITUE",
         "https://www.leparfait.fr/uploads/media/b2d4a2b0f506110a0fb219b84eb75e14.png"
    },
    {
         "LAVANDE",
         "https://www.leparfait.fr/uploads/media/5f1034f091a29.png"
    },
    {
         "Litchi",
         "https://www.leparfait.fr/uploads/media/5f1031ca52f03.png"
    },
    {
         "Mâche",
         "https://www.leparfait.fr/uploads/media/e48232fe05052e50a8c8d0444a34e6ce.png"
    },
    {
         "MAÏS",
         "https://www.leparfait.fr/uploads/media/5f1033eac640f.png"
    },
    {
         "Mandarine",
         "https://www.leparfait.fr/uploads/media/9833da96ec7131086fba0ae58ce36c50.png"
    },
    {
         "Mangue",
         "https://www.leparfait.fr/uploads/media/5f1031db0ec84.png"
    },
    {
         "Marron",
         "https://www.leparfait.fr/uploads/media/defca1707f8bc83c04a514b0b80eab20.png"
    },
    {
         "MELON",
         "https://www.leparfait.fr/uploads/media/413d51bb837a293e32cda766676a19d5.png"
    },
    {
         "MENTHE",
         "https://www.leparfait.fr/uploads/media/bc47ed18b35a44ddbb8f8afb6ac6d645.png"
    },
    {
         "Mirabelle",
         "https://www.leparfait.fr/uploads/media/87e8b7e73de5cc47eb5b3a5ebc200f00.png"
    },
    {
         "MÛRE",
         "https://www.leparfait.fr/uploads/media/2e2cad18d33e0014a87e204395f34e92.png"
    },
    {
         "MYRTILLE",
         "https://www.leparfait.fr/uploads/media/24eb3cca555dbd161498493a899037f2.png"
    },
    {
         "Navet",
         "https://www.leparfait.fr/uploads/media/e3c2b3eee6f72bb0a271a8035f5516e1.png"
    },
    {
         "NECTARINE",
         "https://www.leparfait.fr/uploads/media/ec25d8195aaae744b959dc3b1ad64013.png"
    },
    {
         "Noisette",
         "https://www.leparfait.fr/uploads/media/5f103493314fb.png"
    },
    {
         "Noix",
         "https://www.leparfait.fr/uploads/media/5f1034839e7f3.png"
    },
    {
         "OIGNON",
         "https://www.leparfait.fr/uploads/media/b65a75c5f0125e1ee0127c3b175d96fb.png"
    },
    {
         "Olive",
         "https://www.leparfait.fr/uploads/media/09a2219eaaa8ad94f4629d2d7cc248a3.png"
    },
    {
         "ORANGE",
         "https://www.leparfait.fr/uploads/media/240ceb44dcd3c3cf67baf50a0aa5c189.png"
    },
    {
         "PAMPLEMOUSSE",
         "https://www.leparfait.fr/uploads/media/b7b5d2e3320b2a2c72e7e3a02199846f.png"
    },
    {
         "Panais",
         "https://www.leparfait.fr/uploads/media/5f1033f9df74a.png"
    },
    {
         "Papaye",
         "https://www.leparfait.fr/uploads/media/5f1031f0e77bc.png"
    },
    {
         "PASTÈQUE",
         "https://www.leparfait.fr/uploads/media/5f10320106ab3.png"
    },
    {
         "Patate douce",
         "https://www.leparfait.fr/uploads/media/5f103406c5237.png"
    },
    {
         "PÊCHE",
         "https://www.leparfait.fr/uploads/media/4450e923f80d20212f5c767d543dfd92.png"
    },
    {
         "PERSIL",
         "https://www.leparfait.fr/uploads/media/fb13c43952c8d2c5e0c5f674782fb45c.png"
    },
    {
         "PETIT POIS",
         "https://www.leparfait.fr/uploads/media/0a43c2e78c1f0421a086c20ead4774f2.png"
    },
    {
         "Pied bleu",
         "https://www.leparfait.fr/uploads/media/5f103575f3036.png"
    },
    {
         "Pied de Mouton",
         "https://www.leparfait.fr/uploads/media/5f103560b8124.png"
    },
    {
         "PIMENT",
         "https://www.leparfait.fr/uploads/media/51a690bdf6a44110e06c8cbd1a78b125.png"
    },
    {
         "Poire",
         "https://www.leparfait.fr/uploads/media/4a467449b1688b7542189d11795597b9.png"
    },
    {
         "Poireau",
         "https://www.leparfait.fr/uploads/media/b8c45d532e26f553d8ce341b7da066d6.png"
    },
    {
         "POIS CHICHE",
         "https://www.leparfait.fr/uploads/media/20370c0f263f5d1b5ea1e79242952a17.png"
    },
    {
         "POIVRONS",
         "https://www.leparfait.fr/uploads/media/134232909d390b90f1f785057a9295a3.png"
    },
    {
         "Pomme",
         "https://www.leparfait.fr/uploads/media/76f522f30053c69d266cb4d6adf94fc6.png"
    },
    {
         "POMME DE TERRE",
         "https://www.leparfait.fr/uploads/media/5f10341a79468.png"
    },
    {
         "Potimarron",
         "https://www.leparfait.fr/uploads/media/5f10342ac2562.png"
    },
    {
         "Potiron",
         "https://www.leparfait.fr/uploads/media/c774210cd924dcb72ae29ba5d1dcd58e.png"
    },
    {
         "Prune",
         "https://www.leparfait.fr/uploads/media/ef801de6baf06cb8af3596865fd18913.png"
    },
    {
         "Prunelles",
         "https://www.leparfait.fr/uploads/media/5f1034e1dd6a5.png"
    },
    {
         "Quetsche",
         "https://www.leparfait.fr/uploads/media/5f10320fa790f.png"
    },
    {
         "Radis",
         "https://www.leparfait.fr/uploads/media/975f5f83852e7249e4271a6e75bb1dff.png"
    },
    {
         "Radis noir",
         "https://www.leparfait.fr/uploads/media/5f103439e575f.png"
    },
    {
         "Raisin",
         "https://www.leparfait.fr/uploads/media/5ab8675c7ead33f957a778a7dec75c98.png"
    },
    {
         "Rhubarbe",
         "https://www.leparfait.fr/uploads/media/92bc703a8fafb63ecf3c51a65d7bf715.png"
    },
    {
         "Rutabaga",
         "https://www.leparfait.fr/uploads/media/5f10344c2857d.png"
    },
    {
         "SALICORNE",
         "https://www.leparfait.fr/uploads/media/5f1034d32b3fc.png"
    },
    {
         "Salsifis",
         "https://www.leparfait.fr/uploads/media/5f10346275061.png"
    },
    {
         "TOMATE",
         "https://www.leparfait.fr/uploads/media/583c79f1308b34929a00146c6608a896.png"
    },
    {
         "Topinambour",
         "https://www.leparfait.fr/uploads/media/5f10347276c13.png"
    },
    {
         "Trompette de la mort",
         "https://www.leparfait.fr/uploads/media/5f103552af4ec.png"
    },
    {
         "Truffe noir du Périgord",
         "https://www.leparfait.fr/uploads/media/5f1035438a3e3.png"
    },
    {
         "Violette",
         "https://www.leparfait.fr/uploads/media/5f1034c14beb7.png"
    }
    };
   
    public static Aliment Create(
        int id,
        string? name,
        string? description,
        string? season,
        string? type,
        double? calories,
        string? nutriscore,
        string? imageUrl,
        string? localisation)
    {
        return new Aliment
        {
            Id = id,
            Name = name,
            Description = description,
            Season = season,
            Type = type,
            Calories = calories,
            Nutriscore = nutriscore,
            ImageUrl = imageUrl,
            Localisation = localisation
        };
    }
    // Get Random Value of the array
    public static string GetRandom(string[] array)
    {
        var random = new Random();
        var index = random.Next(0, array.Length);
        return array[index];
    }
    public static IEnumerable<Aliment> GetAll()
    {
        var i = 0;
        var list = new List<Aliment>();
        foreach (var item in Repository)
        {
            list.Add(Create(i++, item.Key.ToLower(), "description", GetRandom(SeasonNames), GetRandom(TypeNames), new Random().NextDouble() * 10.0, GetRandom(NutriscoreNames), item.Value, GetRandom(CountryNames)));
        }
        return list;
    }
}