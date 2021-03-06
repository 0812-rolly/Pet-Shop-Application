using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.BLL
{
    class DataLoader
    {
        public async static void LoadData()
        {
            IProductLogic productLogic = new ProductLogic();

            Product prod1 = new Product()
            {
                Group = "Сухой корм",
                PetType = "Кошки",
                Name = "Hill’s Science Plan",
                ShortDescription = "Сухой корм для кошек",
                LongDescription= "Корм Hills Science Plan корм Hills Science Plan сухой корм для взрослых кошек, склонных к избыточному весу, с курицей Perfect Weight",
                Composition= "Мука из курицы и индейки, размолотый рис, мука из кукурузного глютена, целлюлоза, сухие томатные выжимки, сухая пульпа сахарной свеклы, семя льна, животный жир, гидролизат белка, кокосовое масло, минералы, высушенная морковь.",
                Weight=12,
                Price=5410,
                InStock=100,
                Image = "hills.jpg"
            };

            Product prod2 = new Product()
            {
                Group = "Сухой корм",
                PetType = "Кошки",
                Name = "Royal Canin",
                ShortDescription = "Сухой корм для кошек",
                LongDescription = "Корм Royal Canin для котят от 1 до 4 мес. и для беременных/лактирующих кошек, Mother & Babycat",
                Composition = "Дегидратированный белок мяса птицы, рис, животные жиры, кукурузная мука, изолят белка растительного происхождения, гидролизат белка животного происхождения, соевое масло, растительная клетчатка, свекольный жом, рыбий жир, дрожжи, фруктоолигосахариды, минеральные вещества и экстракт бархатцев.",
                Weight = 4,
                Price = 2713,
                InStock = 5,
                Image = "royal.jpg"
            };

            Product prod3 = new Product()
            {
                Group = "Влажный корм",
                PetType = "Кошки",
                Name = "Royal Canin",
                ShortDescription = "Влажный корм для кошек",
                LongDescription = "Royal Canin кусочки в желе для кошек 1-7 лет: идеальная кожа и шерсть",
                Composition = "Мясо и мясные субпродукты, рыба и рыбные субпродукты, злаки, экстракты белков растительного происхождения, масла и жиры, субпродукты растительного происхождения, минеральные вещества, источники углеводов.",
                Weight = 0.85,
                Price = 61,
                InStock = 18,
                Image = "royal_wet.jpg"
            };

            Product prod4 = new Product()
            {
                Group = "Влажный корм",
                PetType = "Кошки",
                Name = "Purina Pro Plan",
                ShortDescription = "Влажный корм для кошек",
                LongDescription = "Purina Pro Plan кусочки в желе для домашних кошек с индейкой",
                Composition = "Мясо и продукты переработки мяса (в том числе индейка 4%), рыба и продукты переработки рыбы, минеральные вещества, продукты переработки растительного сырья, сахара, витамины.",
                Weight = 0.85,
                Price = 54,
                InStock = 24,
                Image = "purina.jpg"
            };

            Product prod5 = new Product()
            {
                Group = "Игрушки",
                PetType = "Кошки",
                Name = "Tappi",
                ShortDescription = "Игрушка для кошек",
                LongDescription = "Tappi дразнилка \"Стим\", осьминог из натурального меха норки на веревке",
                Composition = "Натуральный мех норки",
                Weight = 0.3,
                Price = 152,
                InStock = 3,
                Image = "octopus.jpg"
            };

            Product prod6 = new Product()
            {
                Group = "Игрушки",
                PetType = "Кошки",
                Name = "Антицарапки",
                ShortDescription = "Игрушка для кошек",
                LongDescription = "Антицарапки игрушка для кошки Голубь с валерианой",
                Composition = "Голубь, валериана",
                Weight = 0.5,
                Price = 184,
                InStock = 7,
                Image = "pigeon.jpg"
            };

            Product prod7 = new Product()
            {
                Group = "Лекарства",
                PetType = "Кошки",
                Name = "Хелвет",
                ShortDescription = "Лекарство для кошек",
                LongDescription = "Хелвет кантарен при заболевании почек и мочевыводящих путей, 100 мл",
                Composition = "В 1000 мл: Berberis vulgaris Ø=D1 – 0,3 мл, Cuprum arsenicosum D6 – 0,2 мкл, Hepar sulfuris D4 trituration – 2,0 г, Lytta vesicatoria Ø=D1 – 3 мкл и вспомогательные вещества: глицерин и воду очищенную",
                Weight = 0.21,
                Price = 1379,
                InStock = 2,
                Image = "helvet.jpg"
            };

            Product prod8 = new Product()
            {
                Group = "Лекарства",
                PetType = "Кошки",
                Name = "KRKA",
                ShortDescription = "Лекарство для кошек",
                LongDescription = "Марфлоксин - противобактериальное средство из группы фторхинолонов III поколения с улучшенными фармакокинетическим свойствами в форме таблеток. Препарат обладает широким спектром бактерицидного действия, основанного на подавлении бактериальных ферментов ДНК-гиразы и топоизомеразы IY, участвующих в репликации ДНК микроорганизмов.",
                Composition = "Марбофлоксацин 5 мн, 20 мг и 80 мг в одной таблетке, и вспомогательные вещества – моногидрат лактозы, повидон, кросповидон, стеарат магния, мясной ароматизатор, гидрогенизированное касторовое масло, дрожжевой порошок, диоксид кремния коллоидный безводный.",
                Weight = 0.43,
                Price = 365,
                InStock = 8,
                Image = "marflox.jpg"
            };

            productLogic.AddProduct(prod1);
            productLogic.AddProduct(prod2);
            productLogic.AddProduct(prod3);
            productLogic.AddProduct(prod4);
            productLogic.AddProduct(prod5);
            productLogic.AddProduct(prod6);
            productLogic.AddProduct(prod7);
            productLogic.AddProduct(prod8);

            //Product p1 = await productLogic.GetProduct(1);
            //Product p2 = await productLogic.GetProduct(2);
            //productLogic.AddProductToCart(p1);
            //productLogic.AddProductToCart(p2);

            return;
        }
    }
}
