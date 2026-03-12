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
- 4단계 코드

## 구현 시 어려웠던 점
1. 버튼이 창 밖으로 조금이라도 나가지 않기 위해 (ClientSize.Width - Running_button.Width, 또는 Height) 과 같이 작성해야 한다는 점을 찾아내야 하는 부분이 첫 도전이었음
2. SoundPlayer 소스 구현하면서 모든 사용자의 PC에서 소리가 오류없이 나도록 Path를 설정하는 과정에서 약간의 어려움이 있었음 (기본 Windows 시스템 사운드 활용)
