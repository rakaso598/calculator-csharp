[📌[C# 초보 강좌] 예제로 배우는 C# 01](https://youtu.be/qZAkIpkPbmc?feature=shared)

위 링크의 C# 초보 강좌를 통해 윈도우 계산기를 제작했습니다.

---

[25.04.12] 진행상황
![image](https://github.com/user-attachments/assets/8a1c8d4d-4cf7-4896-89aa-497652102ef5)

- 함수의 오버로딩(overloading)
같은 함수를 여러번 선언할 수 있지만 매개변수가 달라야 함.
return형은 그 함수가 유니크한지 아닌지는 결정하지 않음. (의미가 없음)

- 기능과 UI는 분리하는 것이 좋다 -> UI는 언제든 변경될 수 있기 때문.

```
public void Flush(Number1);
public void Flush(Number2);
public void Flush(Number1, Number2);
public void Flush();
```

---

[25.04.13] 진행상황
![image](https://github.com/user-attachments/assets/b70e75fd-f28b-4e78-adca-c86eafac0a75)  

- 밸리데이션: 입력값이 유효한지 체크하는 것
- 익셉션: 프로그램이 실행되는 도중에 발생하는 에러
- 디버깅: 프로그램이 실행되는 도중에 발생하는 에러를 찾아내는 것  

- if문으로 걸러내는 것 말고 아예 텍스트박스에 입력을 못하게 하는 방법도 있다. -> 라디오버튼이나 숫자 버튼만 주는 방법 등
- null 이라는 건 보관함 자체가 없다는 것입니다.
- 함수 안에서 빠져나오기 위해서는 return을 사용. 반환값이 void이면 return만 사용하는 것 가능.  

- SelectAll()과 Focus()를 이용해 모든 내용을 선택하게 하고 포커스를 이동하는 등 사용자에게 편리한 기능을 구현할 수 있음.
- 이러한 편리한 기능을 구현하는 것도 프로그래머들이 구현하는데 시간이 오래걸리는 것들 중 하나이다.  

- 그리고 개발자들은 밸리데이션, 익셉션, 디버깅에 시간을 굉장히 많이 쓸 수도 있다.  

---
