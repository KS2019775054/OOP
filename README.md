
ArrLink.cs
>ArrLink.cs 는 배열로 스택을 구현한 코드이며
스택을 구현하기 위한 정수형 배열을 저장하고, top은 현재 스택의 최상위 위치를 나타냅니다. ArrStack 클래스는 생성자를 통해 스택의 크기를 입력받습니다. 입력받은 크기만큼 stack 배열을 생성하고, top 필드를 -1로 초기화합니다.
Push 메소드는 스택에 정수형 데이터 num을 추가합니다. 스택이 가득 찬 경우 스택에 공간이 없습니다라는 메시지를 출력하고, 그렇지 않은 경우 top을 1 증가시킨 후, num을 stack 배열의 top 위치에 저장합니다.
Pop 메소드는 스택에서 최상위 데이터를 제거하고, 해당 데이터를 반환합니다. 스택이 비어있는 경우 스택에 값이 없습니다라는 메시지를 출력하고, -1을 반환합니다. 그렇지 않은 경우 stack 배열에서 top 위치에 있는 데이터를 num에 저장하고, top을 1 감소시킨 후 num을 반환합니다.
IsEmpty 메소드는 스택이 비어있는지 여부를 반환합니다.
실행결과는 아래와 같습니다
![ArrStack](https://github.com/KS2019775054/OOP/blob/main/ArrStack.png?raw=true)


LinkStak.cs
>스택을 구현하기 위한 링크드 리스트를 만들고, top은 top은 스택의 맨 위 노드를 가리키는 포인터입니다. 생성자에서 top을 null로 초기화합니다.
Push 메소드는 데이터를 인자로 받아 새로운 노드를 생성하고, 스택이 비어있다면 새로운 노드를 top에 연결합니다. 스택이 비어있지 않다면 새로운 노드를 top에 연결하고, top을 새로운 노드로 갱신합니다.
Pop 메소드는 스택이 비어있으면 "스택이 비었습니다" 메시지를 출력하고, -1을 반환합니다. 스택이 비어있지 않으면 top 노드의 데이터를 반환하고, top을 다음 노드로 갱신합니다.
IsEmpty 메소드는 top이 null인지 여부를 반환합니다.
실행결과는 아래와 같습니다
![LinkStack](https://github.com/KS2019775054/OOP/blob/main/LinkStack.png?raw=true)


changebin.c
>위 코드에서는 unsigned int 자료형을 사용하여 16진수 값을 저장합니다. scanf() 함수를 사용하여 사용자로부터 16진수 값을 입력받습니다. %x 서식지정자를 사용하여 16진수 값을 입력받습니다.
이후, for 루프를 사용하여 16진수 값을 2진수로 변환합니다. 먼저, i는 31부터 시작하여 0까지 1씩 감소하며, hex >> i 연산은 hex 값을 i 만큼 비트 오른쪽으로 시프트합니다. 이 때, & 연산을 사용하여 오른쪽에서부터 하나씩 값을 추출합니다. 이 값은 0 또는 1이므로, 2진수로 변환된 값이 됩니다.
i는 unsigned int 자료형 크기에 맞춰 0부터 31로 역순 설정했습니다.
출력 결과는 다음과 같습니다.
![LinkStack](https://github.com/KS2019775054/OOP/blob/main/changebin.png?raw=true)
