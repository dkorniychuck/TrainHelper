using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MealPlanWindow.xaml
    /// </summary>
    public partial class MealPlanWindow : Window
    {
        ApplicationContext db;
        public MealPlanWindow()
        {
            InitializeComponent();
            UserKKal.Content = UserKalories().ToString().Substring(0, 4) + "ккал";
            Breakfast(UserKalories());
            Lunch(UserKalories());
            Dinner(UserKalories());
        }
        public double UserKalories()
        {
            db = new ApplicationContext();
            User user = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                user = db.Users.Where(b => b.IsActive == "true").FirstOrDefault();
            }
            if (user != null)
            {
                double kalories = user.KKal;
                return kalories;
            }
            return 0;
        }
        public void Breakfast(double kalories)
        {
            string[] breakfastDishes =
            {
                "Омлет зі сиром та шпинатом",
                "Панкейки з кленовим сиропом",
                "Авокадо-тост з яйцем та лососем",
                "Мюслі з молоком та сухофруктами",
                "Тост з арахісовим маслом та бананом",
                "Бігунська овсянка з мигдальним молоком та медом",
                "Коктейль з молока, мигдалю та банана",
                "Гранола з йогуртом та свіжими фруктами",
                "Фруктовий салат з йогуртом та медом",
                "Смузі з шпинатом, бананом та протеїновим порошком"
            };

            double[] breakfastCaloriesPer100g =
            {
                200, // Омлет їз сиром та шпинатом
                220, // Панкейки з кленовим сиропом
                250, // Авокадо-тост з яйцем та лососем
                300, // Мюслі з молоком та сухофруктами
                180, // Тост з арахісовим маслом та бананом
                200, // Бігунська овсянка з мигдальним молоком та медом
                220, // Коктейль з молока, мигдалю та банана
                350, // Гранола з йогуртом та свіжими фруктами
                180, // Фруктовий салат з йогуртом та медом
                200  // Смузі з шпинатом, бананом та протеїновим порошком
            };
            double[] breakfastProteinsPer100g = {
                12, // Омлет зі сиром та шпинатом
                6,  // Панкейки з кленовим сиропом
                14, // Авокадо-тост з яйцем та лососем
                8,  // Мюслі з молоком та сухофруктами
                7,  // Тост з арахісовим маслом та бананом
                5,  // Бігунська овсянка з мигдальним молоком та медом
                10, // Коктейль з молока, мигдалю та банана
                12, // Гранола з йогуртом та свіжими фруктами
                5,  // Фруктовий салат з йогуртом та медом
                15  // Смузі з шпинатом, бананом та протеїновим порошком
            };

            double[] breakfastFatsPer100g = {
                15, // Омлет зі сиром та шпинатом
                10, // Панкейки з кленовим сиропом
                18, // Авокадо-тост з яйцем та лососем
                6,  // Мюслі з молоком та сухофруктами
                12, // Тост з арахісовим маслом та бананом
                8,  // Бігунська овсянка з мигдальним молоком та медом
                12, // Коктейль з молока, мигдалю та банана
                20, // Гранола з йогуртом та свіжими фруктами
                3,  // Фруктовий салат з йогуртом та медом
                8   // Смузі з шпинатом, бананом та протеїновим порошком
            };

            double[] breakfastCarbsPer100g = {
                5,  // Омлет зі сиром та шпинатом
                35, // Панкейки з кленовим сиропом
                25, // Авокадо-тост з яйцем та лососем
                55, // Мюслі з молоком та сухофруктами
                30, // Тост з арахісовим маслом та бананом
                25, // Бігунська овсянка з мигдальним молоком та медом
                20, // Коктейль з молока, мигдалю та банана
                60, // Гранола з йогуртом та свіжими фруктами
                30, // Фруктовий салат з йогуртом та медом
                25  // Смузі з шпинатом, бананом та протеїновим порошком
            };
            Random random = new Random();
            int randomBreakfast = random.Next(0, breakfastDishes.Count());
            double breakfastGrams = Math.Round(kalories * 0.4 / breakfastCaloriesPer100g[randomBreakfast] * 100);
            double breakfastCalories = Math.Round(UserKalories() * 0.4);
            double breakfastProteins = breakfastProteinsPer100g[randomBreakfast] / 100 * breakfastGrams;
            double breakfastFats = breakfastFatsPer100g[randomBreakfast] / 100 * breakfastGrams;
            double breakfastCarbs = breakfastCarbsPer100g[randomBreakfast] / 100 * breakfastGrams;
            BreakfastName.Content = breakfastDishes[randomBreakfast];
            BreakfastKalories.Content = "Калорійність: " + breakfastCalories + " ккал";
            BreakfastGrams.Content = "Порція: " + breakfastGrams + "г";
            BreakfastPFC.Content = "Білки/Жири/Вуглеводи: " + breakfastProteins + "г/" + breakfastFats + "г/" + breakfastCarbs + "г";
        }
        public void Lunch(double kalories)
        {
            string[] lunchDishes = {
                "Куряче філе з картоплею",
                "Телятина з рисом та овочами",
                "Суп з курячими окорочками",
                "Паста зі смаженою куркою та сиром",
                "Каррі з овочами та куркою",
                "Грильована телятина з картоплею та соусом",
                "Салат з куркою та авокадо",
                "Індичка з рисом та овочами",
                "Рибний стейк з картошкою та соусом",
                "Печена курка з булгуром та зеленню"
            };

            double[] lunchCaloriesPer100g = {
                180, // Куряче філе з картоплею
                200, // Телятина з рисом та овочами
                150, // Суп з курячими окорочками
                250, // Паста зі смаженою куркою та сиром
                220, // Каррі з овочами та куркою
                300, // Грильована телятина з картоплею та соусом
                180, // Салат з куркою та авокадо
                200, // Індичка з рисом та овочами
                220, // Рибний стейк з картошкою та соусом
                180  // Печена курка з булгуром та зеленню
            };
            double[] lunchProteinsPer100g = {
                25, // Куряче філе з картоплею
                22, // Телятина з рисом та овочами
                15, // Суп з курячими окорочками
                20, // Паста зі смаженою куркою та сиром
                18, // Каррі з овочами та куркою
                30, // Грильована телятина з картоплею та соусом
                22, // Салат з куркою та авокадо
                24, // Індичка з рисом та овочами
                25, // Рибний стейк з картошкою та соусом
                22  // Печена курка з булгуром та зеленню
            };

            double[] lunchFatsPer100g = {
                10, // Куряче філе з картоплею
                15, // Телятина з рисом та овочами
                8,  // Суп з курячими окорочками
                15, // Паста зі смаженою куркою та сиром
                12, // Каррі з овочами та куркою
                20, // Грильована телятина з картоплею та соусом
                15, // Салат з куркою та авокадо
                12, // Індичка з рисом та овочами
                18, // Рибний стейк з картошкою та соусом
                15  // Печена курка з булгуром та зеленню
            };

            double[] lunchCarbsPer100g = {
                20, // Куряче філе з картоплею
                30, // Телятина з рисом та овочами
                10, // Суп з курячими окорочками
                35, // Паста зі смаженою куркою та сиром
                28, // Каррі з овочами та куркою
                40, // Грильована телятина з картоплею та соусом
                20, // Салат з куркою та авокадо
                35, // Індичка з рисом та овочами
                30, // Рибний стейк з картошкою та соусом
                25  // Печена курка з булгуром та зеленню
            };

            Random random = new Random();
            int randomLunch = random.Next(0, lunchDishes.Count());
            double lunchGrams = Math.Round(kalories * 0.3 / lunchCaloriesPer100g[randomLunch] * 100);
            double lunchCalories = Math.Round(UserKalories() * 0.3);
            double lunchProteins = lunchProteinsPer100g[randomLunch] / 100 * lunchGrams;
            double lunchFats = lunchFatsPer100g[randomLunch] / 100 * lunchGrams;
            double lunchCarbs = lunchCarbsPer100g[randomLunch] / 100 * lunchGrams;
            LunchName.Content = lunchDishes[randomLunch];
            LunchKalories.Content = "Калорійність: " + lunchCalories + " ккал";
            LunchGrams.Content = "Порція: " + lunchGrams + "г";
            LunchPFC.Content = "Білки/Жири/Вуглеводи: " + lunchProteins + "г/" + lunchFats + "г/" + lunchCarbs + "г";
        }
        public void Dinner(double kalories)
        {
            string[] dinnerDishes = {
                "Лосось з овочами на пару",
                "Стейк з курки з картоплею",
                "Рибний суп з овочами",
                "Овочевий салат з тунцем",
                "Курячі крильця з картоплею",
                "Салат з креветками та авокадо",
                "Індичка на грилі з овочами",
                "Смажені курчатки з рисом",
                "Телятина з картоплею та соусом",
                "Лосось з овочами на грилі"
                };

            double[] dinnerCaloriesPer100g = {
                200, // Лосось з овочами на пару
                250, // Стейк з куркою з картоплею
                150, // Рибний суп з овочами
                180, // Овочевий салат з тунцем
                220, // Курячі крильця з картоплею
                180, // Салат з креветками та авокадо
                180, // Індичка на грилі з овочами
                220, // Смажені курчатки з рисом
                200, // Телятина з картоплею та соусом
                250  // Лосось з овочами на грилі
            };
            double[] dinnerProteinsPer100g = {
                25, // Лосось з овочами на пару
                26, // Стейк з курки з картоплею
                12, // Рибний суп з овочами
                15, // Овочевий салат з тунцем
                22, // Курячі крильця з картоплею
                18, // Салат з креветками та авокадо
                24, // Індичка на грилі з овочами
                25, // Смажені курячі грудки з рисом
                23, // Телятина з картоплею та соусом
                26  // Лосось з овочами на грилі
            };

            double[] dinnerFatsPer100g = {
                15, // Лосось з овочами на пару
                18, // Стейк з курки з картоплею
                8,  // Рибний суп з овочами
                12, // Овочевий салат з тунцем
                16, // Курячі крильця з картоплею
                12, // Салат з креветками та авокадо
                15, // Індичка на грилі з овочами
                18, // Смажені курячі грудки з рисом
                20, // Телятина з картоплею та соусом
                18  // Лосось з овочами на грилі
            };

            double[] dinnerCarbsPer100g = {
                5,  // Лосось з овочами на пару
                30, // Стейк з курки з картоплею
                10, // Рибний суп з овочами
                20, // Овочевий салат з тунцем
                20, // Курячі крильця з картоплею
                15, // Салат з креветками та авокадо
                10, // Індичка на грилі з овочами
                30, // Смажені курячі грудки з рисом
                25, // Телятина з картоплею та соусом
                15  // Лосось з овочами на грилі
            };
            Random random = new Random();
            int randomDinner = random.Next(0, dinnerDishes.Count());
            double dinnerGrams = Math.Round(kalories * 0.2 / dinnerCaloriesPer100g[randomDinner] * 100);
            double dinnerCalories = Math.Round(UserKalories() * 0.2);
            double dinnerProteins = dinnerProteinsPer100g[randomDinner] / 100 * dinnerGrams;
            double dinnerFats = dinnerFatsPer100g[randomDinner] / 100 * dinnerGrams;
            double dinnerCarbs = dinnerCarbsPer100g[randomDinner] / 100 * dinnerGrams;
            DinnerName.Content = dinnerDishes[randomDinner];
            DinnerKalories.Content = "Калорійність: " + dinnerCalories + " ккал";
            DinnerGrams.Content = "Порція: " + dinnerGrams + "г";
            DinnerPFC.Content = "Білки/Жири/Вуглеводи: " + dinnerProteins + "г/" + dinnerFats + "г/" + dinnerCarbs + "г";
        }
            private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window();
            personalAccount_Window.Show();
            this.Close();
        }
    }
}
