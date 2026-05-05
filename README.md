# 簡易電子琴 (Simple Electronic Organ) - C# Windows Forms

## 專案簡介
本專案為一個基於 C# Windows Forms 開發的互動式電子琴應用程式。使用者可以透過介面上的琴鍵進行彈奏，程式除了支援基本發聲外，更實作了動態介面縮放以及錄音回放功能，展現了對 Win32 API 調用、資料結構應用與 UI 狀態管理的掌握。

## 核心功能
- **八音階發聲**：支援標準八音階（Do, Re, Mi, Fa, Sol, La, Si, High Do），使用 Win32 API `Beep` 函式驅動 PC 喇叭發聲。
- **錄音與回放 (加分功能)**：
  - **錄音模式**：切換至錄音狀態後，程式會利用 `List<int>` 動態記錄使用者的彈奏音符順序。
  - **回放功能**：一鍵回放錄製好的旋律，並在音符間加入微小延遲以模擬真實彈奏節奏。
- **介面自動縮放 (Responsive UI)**：
  - 程式啟動時會透過 `Dictionary` 紀錄所有控制項的原始比例。
  - 支援 `SizeChanged` 事件，確保琴鍵按鈕隨視窗縮放自動調整位置與大小。

## 技術實現細節
- **底層呼叫**：透過 `DllImport("kernel32.dll")` 調用系統級 `Beep(int frequency, int duration)` 函式。
- **事件委派**：實作 `InitializeButton()` 方法，讓多個琴鍵按鈕共用同一個事件處理函式，簡化程式架構。
- **資料儲存**：
  - 使用 `Rectangle` 結構管理幾何資訊。
  - 使用 `List<int>` 儲存音符索引，實現動態長度的錄音紀錄。

## 開發環境
- **語言**：C#
- **框架**：.NET Framework (Windows Forms)
- **開發工具**：Visual Studio 2022
- **關鍵命名空間**：
  - `System.Runtime.InteropServices` (API 調用) 
  - `System.Media` (音效處理預留)
  - `System.Drawing` (介面幾何計算)
