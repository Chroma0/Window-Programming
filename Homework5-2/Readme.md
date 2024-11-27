## 簡介
### Practice 5-2：簡易版雙人戰棋 
- 回合制戰棋遊戲，玩家操作三種職業的棋子進行對戰。
## 遊戲階段
1. **準備階段**：
   - 玩家選擇棋子，配置於棋盤上。
   - 倒數結束時，剩餘棋子會自動放置。

2. **戰鬥階段**：
   - 每種棋子依順序行動：戰士 → 法師 → 遊俠。
   - 執行攻擊、移動或技能等動作。

3. **遊戲結束**：
   - 當玩家所有棋子失去 HP，遊戲結束。

## 技術要求
- 棋盤為 7x6，使用 Button Array 實作。
- 三種職業需利用繼承設計。
- 支援攻擊範圍檢查與技能效果。