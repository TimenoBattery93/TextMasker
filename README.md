# TextMasker
DocShield: Multi-format document privacy tool with dynamic masking and real-time sensitivity control. / 多格式文档隐私屏蔽工具，支持随机敏感内容隐藏与实时强度调节。
# DocShield - 文档智能屏蔽工具  
**Smart Document Masking Tool for Privacy Protection**  

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-green.svg)](https://dotnet.microsoft.com/)

## 📖 概述 / Overview  
一款基于 Windows Forms 的桌面应用，支持读取 Word、PDF、TXT 等文档，并**随机屏蔽内容**。  
A Windows Forms desktop application that reads Word, PDF, TXT documents and **randomly masks content**.

## ✨ 功能 / Features  
- **多格式支持**: 读取 Word (.doc/.docx)、PDF、TXT 文档  
  _Multi-format Support_: Read Word (.doc/.docx), PDF, TXT files  
- **智能屏蔽**: 按比例随机替换文本字符 (如 `*`)  
  _Smart Masking_: Randomly replace characters by ratio (e.g., `*`)  
- **实时预览**: 滑动条动态调整屏蔽比例  
  _Real-time Preview_: Adjust masking ratio with a slider  

## 🛠️ 技术栈 / Tech Stack  
- **语言 / Language**: C#  
- **框架 / Framework**: .NET Framework 4.7.2  
- **库 / Libraries**:  
  - iTextSharp (PDF 解析 / PDF parsing)  
  - Microsoft.Office.Interop.Word (Word 文档处理 / Word processing)  

## 🚀 快速开始 / Getting Started  
### 安装 / Installation  
1. 克隆仓库 / clone:  
   ```bash
   https://github.com/TimenoBattery93/TextMasker.git

## 📝使用说明 / Usage Instructions
**1. 打开文档 / Open a Document**  
点击 "Open" 按钮，选择支持的文档格式（Word、PDF、TXT）。  
Click the "Open" button to select a supported file format (Word, PDF, TXT).

**2. 启用屏蔽功能 / Enable Masking**  
勾选 "Enable Random Masking" 复选框以启用随机屏蔽功能。  
Check the "Enable Random Masking" checkbox to activate the random masking feature.

**3. 调整屏蔽比例 / Adjust Masking Ratio**  
拖动滑动条，实时调整屏蔽比例（0% - 100%）。  
Drag the slider to adjust the masking ratio in real-time (0% - 100%).

**4. 查看效果 / View Results**  
屏蔽后的内容会实时显示在主界面中。  
The masked content will be displayed in real-time on the main interface.

**5. 保存结果（可选） / Save Results (Optional)**  
点击 "Save" 按钮，将屏蔽后的内容保存为 TXT 文件。  
Click the "Save" button to export the masked content as a TXT file.  

## 注意事项 / Notes  
支持的文档格式: Word (.doc/.docx)、PDF、TXT  
Supported Formats: Word (.doc/.docx), PDF, TXT

屏蔽符号: 默认使用 *，可在代码中自定义  
Masking Symbol: Default is *, customizable in code

实时预览: 调整滑动条时，屏蔽效果会即时更新  
Real-time Preview: Masking updates instantly when adjusting the slider  

## 📝 开发指南 / Development
项目结构 / Project Structure
DocShield/  
├── DocShield/          # 主项目代码 / # Main project code  
│   ├── Forms/          # 窗体设计文件 / # Form design files  
│   ├── Utilities/      # 工具类 (PDF/Word 解析器) / # Utility classes (PDF/Word parsers)  
│   └── App.config      # 配置文件 / # Configuration file  
├── docs/               # 文档和截图 / # Documentation and screenshots  
└── README.md           # 项目说明 / # Project description

## 📜 许可证 / License
本项目基于 MIT License 开源。

作者 / Author: [Naite Xu]  
联系方式 / Contact: [nxu0365@gmail.com]  
致谢 / Acknowledgements: iTextSharp 和 Microsoft Interop 开发团队
