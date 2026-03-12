# 🎓 버튼잡기게임(C# 코딩)

## ⭐ 개요

## 실행 화면
- 1단계 코드
<img width="799" height="475" alt="image" src="https://github.com/user-attachments/assets/dd683417-cc48-41ee-8904-22d118990efb" />

버튼 위로 커서를 옮기면 버튼이 화면 밖으로 나가지 않는 선에서 이동하며, 창 제목에 현재 위치까지 잘 표시됨을 알 수 있다.

- 2단계 코드

https://github.com/user-attachments/assets/f7f12173-add9-46cf-9406-0dbabee24809

도망 소리, 클리어소리 및 팝업 추가

- 3단계 코드

https://github.com/user-attachments/assets/8b5e31cf-4677-4159-8935-b3962e93120a

버튼 크기 축소 및 점수 시스템 구현

- 4단계 코드

https://github.com/user-attachments/assets/0b8b6b77-fa18-47ea-b3b4-4f16449e31ce

사용자 간접 인터페이스 상향 및 버그 수정 및 게임오버, 리셋 적용

## 구현 시 어려웠던 점
1. 버튼이 창 밖으로 조금이라도 나가지 않기 위해 (ClientSize.Width - Running_button.Width, 또는 Height) 과 같이 작성해야 한다는 점을 찾아내야 하는 부분이 첫 도전이었음
2. SoundPlayer 소스 구현하면서 모든 사용자의 PC에서 소리가 오류없이 나도록 Path를 설정하는 과정에서 약간의 어려움이 있었음 (기본 Windows 시스템 사운드 활용)
3. 코드 우선순위를 잘못 설정하여 버튼이 무조건 도망가는 문제가 있었음
4. 글자는 그대로 크기가 적용되어 글자가 1글자씩 사라지는 문제가 있어서 폰트도 10%씩 감소되게 하여서 해결함
5. 소리가 게임 리셋 후 사라지는 문제가 있어서 객체화시켜서 수정했음
