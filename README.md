# TextMasker
DocShield: Multi-format document privacy tool with dynamic masking and real-time sensitivity control. / 多格式文档隐私屏蔽工具，支持随机敏感内容隐藏与实时强度调节。
# DocShield - 文档智能屏蔽工具  
**Smart Document Masking Tool for Privacy Protection**  

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-green.svg)](https://dotnet.microsoft.com/)

## 📖 概述 / Overview  
一款基于 Windows Forms 的桌面应用，支持读取 Word、PDF、TXT 等文档，并**随机屏蔽敏感内容**，保护隐私信息。  
A Windows Forms desktop application that reads Word, PDF, TXT documents and **randomly masks sensitive content** for privacy protection.

## ✨ 功能 / Features  
- **多格式支持**: 读取 Word (.doc/.docx)、PDF、TXT 文档  
  _Multi-format Support_: Read Word (.doc/.docx), PDF, TXT files  
- **智能屏蔽**: 按比例随机替换文本字符 (如 `*`)  
  _Smart Masking_: Randomly replace characters by ratio (e.g., `*`)  
- **实时预览**: 滑动条动态调整屏蔽比例  
  _Real-time Preview_: Adjust masking ratio with a slider  
- **用户友好**: 简洁的界面和操作指引  
  _User-friendly_: Clean UI with intuitive controls  

## 🛠️ 技术栈 / Tech Stack  
- **语言**: C#  
- **框架**: .NET Framework 4.7.2  
- **库**:  
  - iTextSharp (PDF 解析 / PDF parsing)  
  - Microsoft.Office.Interop.Word (Word 文档处理 / Word processing)  

## 🚀 快速开始 / Getting Started  
### 安装 / Installation  
1. 克隆仓库:  
   ```bash
   
