using DeserializeExtra;
using System.Text.Json;
namespace DeserializeExtra
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public string plate { get; set; }
        public string reg_at { get; set; }
        public string person { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int make_year { get; set; }
        public string color { get; set; }
        public string fuel { get; set; }
        public int capacity { get; set; }
        public int own_weight { get; set; }
        public int total_weight { get; set; }
        public string body { get; set; }
        public int oper_code { get; set; }
        public string category { get; set; }
        public string reg_addr_koatuu { get; set; }
        public string departament { get; set; }
        public string vin { get; set; }
        public string first_reg_at { get; set; }
        public int seating { get; set; }
        public object standing { get; set; }
        public object chassis { get; set; }
        public string region { get; set; }
        public int plate_cost { get; set; }
        public string plate_cost_reason { get; set; }
        public string departament_address { get; set; }
        public string operation { get; set; }
        public string kind { get; set; }
        public string address { get; set; }
        public int price { get; set; }
        public bool is_actual { get; set; }
    }

    public class Root
    {
        public bool success { get; set; }
        public string plate { get; set; }
        public string plate_en { get; set; }
        public Data data { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            string jsonString = """
                {
                "success": true,
                "plate": "AA9999TC",
                "plate_en": "AA9999TC",
                "data": {
                    "plate": "AA9999TC",
                    "reg_at": "2018-11-09",
                    "person": "Фізична особа",
                    "brand": "TESLA",
                    "model": "MODEL X",
                    "make_year": 2017,
                    "color": "ЧЕРВОНИЙ",
                    "fuel": "ЕЛЕКТРО",
                    "capacity": 0,
                    "own_weight": 2510,
                    "total_weight": 3021,
                    "body": "УНІВЕРСАЛ-B",
                    "oper_code": 100,
                    "category": "B",
                    "reg_addr_koatuu": "8038200000",
                    "departament": "ТСЦ 8041",
                    "vin": "5YJXCBE2XHF043074",
                    "first_reg_at": "2018-11-09",
                    "seating": 6,
                    "standing": null,
                    "chassis": null,
                    "region": "Місто Київ",
                    "plate_cost": 72000,
                    "plate_cost_reason": "Чотири однакові цифри",
                    "departament_address": "04128, м. Київ, вул. Туполєва, 19",
                    "operation": "ПЕРВИННА РЕЄСТРАЦIЯ ТЗ ПРИДБАНОГО В ТОРГІВЕЛЬНІЙ ОРГАНІЗАЦІЇ, ЯКИЙ ВВЕЗЕНО З-ЗА КОРДОНУ",
                    "kind": "ЛЕГКОВИЙ",
                    "address": "М.КИЇВ\nРайон ПЕЧЕРСЬКИЙ",
                    "price": 33300,
                    "is_actual": true
                        }
                    }
                """;
            Root? carplateRoot = JsonSerializer.Deserialize<Root>(jsonString);
            Console.WriteLine($"VIN: {carplateRoot?.data?.vin}");
            Console.WriteLine($"make_year: {carplateRoot?.data?.make_year}");
            Console.WriteLine($"is_actual: {carplateRoot?.data?.is_actual}");
        }
    }
}