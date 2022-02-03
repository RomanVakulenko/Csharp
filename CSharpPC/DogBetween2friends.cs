// Сколько раз перебежит собака от одного друга к другому, если они ИДУТ НАВСТРЕЧУ друг другу

int count = 0;
int distance = 10000; // метров
int FirstFriendSpeed = 1; //метров в сек
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int Friend = 2;
int Time = 0;

while (distance > 10)
{
    if (Friend == 1)
    {
        Time = distance/(FirstFriendSpeed + dogSpeed);
        Friend = 2;
    } else
    { 
        Time = distance/(FirstFriendSpeed + dogSpeed);
        Friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed)*Time;
    count++;
}
Console.Write ("Собака перебежала от 1 друга к другому столько раз = ");
Console.Write (count);
