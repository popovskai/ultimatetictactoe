# Ultimate Tic-Tac-Toe

Проект по предметот Визуелно програмирање изработен од Ивана Поповска (индекс 163012) и Сандра Алексовска (индекс 163029).

## Објаснување на проблемот

Ultimate Tic-Tac-Toe е посложена верзија на познатата игра икс-точка (Tic-Tac-Toe). Играта е составена од една голема табела која е составена од 9 помали табели. Секој од 9-те помали табели ја претставува помалата верзија од играта. Играчите играат наизменично. За еден играч да победи во играта потребно е да победи во 3 од помалите табели и тоа во валиден редослед (според правилата на икс-точка). Дополнително, ако едниот играч изигра во некое од полињата на некоја од малите табели, следниот играч мора да игра во табелата во која се пресликува полето во кое играл претходниот играч.

Подетално објаснување за правилата на играта: https://en.wikipedia.org/wiki/Ultimate_tic-tac-toe

## Решение

Играта е имплементирана преку една форма. Формата создржи три панели:
1. MenuPanel
2. InstructionsPanel
3. GamePanel

Во MenuPanel се наоѓаат елементите од главното мени. Во главното мени има две копчиња кои водат до инструкциите и до почеток на играта.

---

Во текот на играта се чуваат податоци за кој играч е на потег и за пополнетоста на табелите.

```cs
public enum Player { X, O, NONE};
private Player CurrentTurn;

private SmallTable[,] tables;
```

Класата SmallTable е опишана подолу.

При почетокот на секоја игра се повикува функцијата InitGame(), која ја иницира играта и случајно го избира играчот кој ќе биде прв на потег.

```cs
private void InitGame() {
	if(random.Next()%2 == 0) {
        SetPlayerTurn(Player.X);
    } else {
        SetPlayerTurn(Player.O);
    }

    tables = new SmallTable[3, 3];
    tables[0, 0] = new SmallTable(this, 0, 0, t00);
    tables[0, 1] = new SmallTable(this, 0, 1, t01);
    tables[0, 2] = new SmallTable(this, 0, 2, t02);

    tables[1, 0] = new SmallTable(this, 1, 0, t10);
    tables[1, 1] = new SmallTable(this, 1, 1, t11);
    tables[1, 2] = new SmallTable(this, 1, 2, t12);

    tables[2, 0] = new SmallTable(this, 2, 0, t20);
    tables[2, 1] = new SmallTable(this, 2, 1, t21);
    tables[2, 2] = new SmallTable(this, 2, 2, t22);
            
    for(int i = 0; i < 3; i++) {
        for(int j = 0; j < 3; j++) {
            tables[i, j].SetFocused(true);
        }
    }
}
```

Проверката дали некој играч победил (и за малите и за големата табела) се прави со следната функција:
```cs
public bool HasWon(int i, int j, GameForm.Player player) {
    // check horizontal
    if (tables[i, 0].GetWonBy() == player && tables[i, 1].GetWonBy() == player && tables[i, 2].GetWonBy() == player) {
        return true;
    }

    // check vertical
    if (tables[0, j].GetWonBy() == player && tables[1, j].GetWonBy() == player && tables[2, j].GetWonBy() == player) {
        return true;
    }

    // check main diaognal
    if (tables[0, 0].GetWonBy() == player && tables[1, 1].GetWonBy() == player && tables[2, 2].GetWonBy() == player) {
        return true;
    }

    // check secondary diagonal
    if (tables[0, 2].GetWonBy() == player && tables[1, 1].GetWonBy() == player && tables[2, 0].GetWonBy() == player) {
        return true;
    }

    return false;
}
```

## Функција

## Screenshots