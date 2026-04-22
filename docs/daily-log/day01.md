# Day 1｜完成 EquipmentRepairSystem 基礎 API 與 Swagger 測試

## 今天做了什麼
- 成功安裝並配置 Visual Studio 2022 與 .NET 8.0 SDK，完成開發環境標準化。
- 從零建立名為 EquipmentRepairSystem 的 ASP.NET Core Web API 專案，並確認具備 Controllers 架構。
- 撰寫 Ticket.cs 類別，定義報修單的核心欄位：Id、Description、Status、RepairerName。
- 修改 TicketsController，讓 API 能將 C# 物件轉換為 JSON 格式回傳。
- 成功使用 Swagger UI 呼叫 API 並取得測試資料。

## 今天完成了什麼
- 確認開發環境已統一到 VS 2022 + .NET 8。
- 專案已具備最基本的 Model 與 Controller。
- API 已能正常回傳 JSON。
- 已能透過 Swagger UI 進行基本測試。

## 遇到的問題
- 一開始使用 VS 2026（.NET 9/10）時，專案預設採用較新的 OpenAPI/Scalar 介面，與原本計畫書預設的 Swagger 流程不同。
- `launchSettings.json` 預設未自動開啟瀏覽器，導致程式雖然啟動成功，但一開始看不到畫面，誤以為是 404 問題。
- 在 C# 基礎練習時，曾把 `List` 的資料宣告寫在類別外部，導致編譯錯誤。

## 我最後怎麼解
- 依照「主線不分心」原則，將環境統一切換為 VS 2022 與 .NET 8，讓教材、開發流程與業界常見配置更一致。
- 建立專案時勾選 OpenAPI 支援，讓 Swagger 回到熟悉且可直接測試 API 的模式。
- 將資料模型（Ticket）與邏輯處理（Controller）分開，讓專案結構更符合 ASP.NET Core 的分層方式。

## 今天學到的關鍵觀念
- `{ get; set; }` 不只是變數寫法，而是後端框架讀取與寫入資料的重要入口。
- 後端物件會被轉換成 JSON，例如 `{"id":1, ...}`，這是前後端溝通的基礎格式。
- `[Route("[controller]")]` 會決定 API 的路由，例如 `/Tickets`，也就是外部如何透過網址找到後端程式。

## 今天的反思
- 我今天最大的進展，是把開發環境、專案骨架、Model、Controller 與 Swagger 測試整條流程打通。
- 我今天最容易誤會的地方，是把新版本工具的預設行為，誤認為是自己程式寫錯。
- 我今天學到，當開發目標是快速建立作品時，環境與教材對齊比硬追最新版本更重要。

## 明天要做什麼
- 補齊 Ticket 的 CRUD 能力。
- 開始思考資料應該先放記憶體，還是接資料庫。
- 整理 README，讓 GitHub 專案更像正式作品。