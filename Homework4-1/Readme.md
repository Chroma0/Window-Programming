## 簡介
### Practice 4-1：翻牌小遊戲  
- 記憶翻牌遊戲，目標是將所有的牌面配對完成。
## 用法
#### 1. 遊戲規則  
- 使用九張圖片（包含八張牌面和一張牌背），所有牌初始狀態為翻到背面。
- 每次可以挑選兩張牌，若配對成功，按鈕將被禁用。
- 若配對失敗，可點選「繼續」將牌翻回背面。
- 當所有牌面被成功配對時，遊戲結束，並跳出提示訊息「你贏了」。

#### 2. 遊戲操作  
- **開始遊戲**：隨機分配牌的位置並初始化遊戲。
- **繼續**：當挑選的兩張牌不匹配時，翻回背面；若未達條件，按鈕將保持禁用狀態。
- **離開遊戲**：結束遊戲並退出應用程式。

#### 3. 勝利條件  
- 當所有牌被成功翻開並配對，顯示完成提示，所有按鈕維持灰色狀態。