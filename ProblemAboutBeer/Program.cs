// 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка.
// До каждого бара идти 15-20 минут,
// каждый пьет пинту за 15 минут.
// У первого друга лимит выпитого 1.1 литра,
// у второго 1.5,
// у третьего 2.2 литра,
// у 4 - 3.3 литра, это их максимум.
// Необходимо выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет.
// И сколько всего времени будет потрачено на выпивку.

double pinta = 0.473176;
int size = 4;
string[] nameFriend = { "Первый друг",
                        "Второй друг",
                        "Третий друг",
                        "Четвётый друг" };
double[] limitFriend = { 1.1,
                         1.5,
                         2.2,
                         3.3 };
double pintaTime = 15;
double minTime = 15;
double maxTime = 30;

double[] countBar = new double[size];
double[] firstTime = { -minTime, -minTime, -minTime, -minTime };
double[] secondTime = { -maxTime, -maxTime, -maxTime, -maxTime };

for (int i = 0; i < size; i++)
{
    while (limitFriend[i] > 0)
    {
        limitFriend[i] -= pinta;
        countBar[i]++;
        firstTime[i] += pintaTime + minTime;
        secondTime[i] += pintaTime + maxTime;
    }
}
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"{nameFriend[i]} упадёт после пинты в {countBar[i]} баре. На это у него уйдёт от {firstTime[i]} до {secondTime[i]}");
}
