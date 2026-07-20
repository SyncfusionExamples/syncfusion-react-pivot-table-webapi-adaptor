<div align="center">
  <a href="https://www.syncfusion.com/react-components/react-pivot-table">
    <img src="https://raw.githubusercontent.com/SyncfusionExamples/Logos/master/React/react-logo.png" alt="React Pivot Table logo" width="120">
  </a>

  <h1>Syncfusion® React Pivot Table – Web API Adaptor Quick Start</h1>

  <p>
    A production-ready quick start that connects the <strong>Syncfusion® React Pivot Table</strong> to an <strong>ASP.NET Core Web API</strong> backend using the <strong>WebApiAdaptor</strong> — enabling remote data binding and full CRUD operations over REST endpoints.
  </p>

  <p>
    <a href="https://react.dev/"><img src="https://img.shields.io/badge/React-18%2B-61DAFB?style=for-the-badge&logo=react&logoColor=white" alt="React"></a>
    <a href="https://dotnet.microsoft.com/apps/aspnet"><img src="https://img.shields.io/badge/.NET-8.0%2B-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET"></a>
    <a href="https://www.syncfusion.com/react-components/react-pivot-table"><img src="https://img.shields.io/badge/Syncfusion-EJ2-FF9C00?style=for-the-badge&logo=syncfusion&logoColor=white" alt="Syncfusion"></a>
    <a href="https://github.com/SyncfusionExamples/webapi-adaptor-with-pivot-table/blob/master/LICENSE"><img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" alt="License"></a>
  </p>
</div>

---

## 📑 Table of Contents

- [🚀 Quick Overview](#-quick-overview)
- [✨ Key Features](#-key-features)
- [🛠️ Prerequisites](#-prerequisites)
- [📂 Project Structure](#-project-structure)
- [⚙️ Installation & Setup](#-installation--setup)
  - [1. Clone the Repository](#1-clone-the-repository)
  - [2. Backend – ASP.NET Core Web API](#2-backend--aspnet-core-web-api)
  - [3. Frontend – React Pivot Table](#3-frontend--react-pivot-table)
- [▶️ Running the Application](#-running-the-application)
- [🧪 Testing CRUD Operations](#-testing-crud-operations)
- [🔧 Troubleshooting](#-troubleshooting)
- [📖 API Reference](#-api-reference)
- [🤝 Contributing](#-contributing)
- [📜 License & Support](#-license--support)
- [📚 Related Resources](#-related-resources)

---

## 🚀 Quick Overview

This project demonstrates how to bind the **Syncfusion® React Pivot Table** to a remote **ASP.NET Core Web API** backend using the [`WebApiAdaptor`](https://ej2.syncfusion.com/react/documentation/data/adaptors/webapi-adaptor) of the [`DataManager`](https://ej2.syncfusion.com/react/documentation/data/getting-started). The WebApiAdaptor extends the ODataAdaptor and is purpose-built for ASP.NET Web API endpoints that follow OData query conventions.

| Component          | Technology                         | Purpose                                              |
| ------------------ | ---------------------------------- | ---------------------------------------------------- |
| 🎨 Frontend        | React 18+ + Syncfusion® EJ2        | Render the interactive Pivot Table UI                |
| ⚙️ Backend         | ASP.NET Core 8.0+ (NewtonsoftJson) | Serve data, perform CRUD, preserve property casing   |
| 🔌 Adaptor         | `WebApiAdaptor`                    | Bridge between Pivot Table and Web API over OData    |
| 📊 Sample Data     | In-memory `OrdersDetails` list     | Simulate 45 order records for the Pivot Table        |

> 💡 The WebApiAdaptor is ideal when you want full server-side control over query processing, filtering, and data transformation while staying compatible with the OData query syntax the Syncfusion DataManager generates.

---

## ✨ Key Features

- 📊 **Remote Data Binding** – Connects the Pivot Table to an ASP.NET Core Web API endpoint over HTTP.
- 🔄 **Full CRUD Support** – Insert, update, and delete records directly from the Pivot Table drill-through grid.
- 🎨 **OData-Style Querying** – Built on top of the ODataAdaptor, so the Web API receives OData-formatted query parameters.
- 🗂️ **Standardized Response Format** – Returns data as `{ Items, Count }` for consistent client-side parsing.
- 🔑 **Primary Key Configuration** – Uses `OrderID` as the primary key for unique record identification.
- 🌐 **CORS-Enabled** – Preconfigured to allow cross-origin requests from the React dev server.
- 🛡️ **Property Casing Preservation** – Uses `DefaultContractResolver` to keep PascalCase fields like `OrderID`, `ShipCity`.
- ⚡ **Drill-Through Editing** – Double-click a pivot cell to add, edit, or delete underlying records in a pop-up grid.
- 📦 **Ready-to-Run** – Clone, build, and start both projects — no database setup required (in-memory sample data).

---

## 🛠️ Prerequisites

Make sure the following software and packages are installed on your machine before running the project.

| Software / Package            | Version       | Purpose                                       |
| ----------------------------- | ------------- | --------------------------------------------- |
| 🟢 Node.js                    | 18.x or later | Runtime for the React development server      |
| ⚛️ React                      | 18.x or later | Build the Pivot Table client                  |
| � TypeScript                 | 5.x or later  | Type-safe development of the React client     |
| ⚡ Vite                       | 5.x or later  | Fast dev server and build tool for the React client |
| �🟣 .NET SDK                   | 8.0 or later  | Build and run the ASP.NET Core Web API        |
| 🧑‍💻 Visual Studio / VS Code  | Latest        | Configure and run the backend API             |
| 📦 @syncfusion/ej2-react-pivotview | 33.1.45+ | React Pivot Table component                   |
| 📦 @syncfusion/ej2-data       | 33.1.45+      | `DataManager` and `WebApiAdaptor`             |
| 📦 Microsoft.AspNetCore.Mvc.NewtonsoftJson | 8.0+ | Preserve original property casing during JSON serialization |

---

## 📂 Project Structure

```
webapi-adaptor-with-pivot-table/
├── 📁 Client/                              # React frontend (Pivot Table, TypeScript)
│   ├── 📁 public/
│   │   └── index.html
│   ├── 📁 src/
│   │   ├── App.css                          # Component styles
│   │   ├── App.tsx                          # Pivot Table with WebApiAdaptor configuration
│   │   ├── index.css
│   │   ├── main.tsx                         # React entry point
│   │   └── vite-env.d.ts
│   ├── index.html
│   ├── package.json                         # React dependencies & scripts
│   ├── tsconfig.app.json
│   ├── tsconfig.json
│   ├── tsconfig.node.json
│   └── vite.config.ts
│
├── 📁 WebApiAdaptor/                       # ASP.NET Core Web API backend
│   ├── 📁 Controllers/
│   │   └── OrdersController.cs             # REST endpoints: GET, POST, PUT, DELETE
│   ├── 📁 Models/
│   │   └── OrdersDetails.cs                # Order data model + sample data
│   ├── 📁 Properties/
│   │   └── launchSettings.json
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs                          # CORS + Newtonsoft.Json configuration
│   ├── WebApiAdaptor.csproj                # Project file
│   └── WebApiAdaptor.http                  # Endpoint testing file
│
├── 📄 README.md                            # You are here
```

---

## ⚙️ Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/webapi-adaptor-with-pivot-table.git
cd webapi-adaptor-with-pivot-table
```

### 2. Backend – ASP.NET Core Web API

The backend project lives in the `WebApiAdaptor/` folder.

#### 2.1 Restore dependencies

```bash
cd WebApiAdaptor
dotnet restore
```

#### 2.2 Verify the required NuGet package

Ensure `Microsoft.AspNetCore.Mvc.NewtonsoftJson` is referenced in `WebApiAdaptor.csproj`. It is required so the API serializes properties using their original PascalCase names (`OrderID`, `ShipCity`, etc.) instead of the default camelCase.

```bash
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
```

#### 2.3 Inspect the configuration

`Program.cs` already configures:

- ✅ **NewtonsoftJson** with `DefaultContractResolver` to preserve property casing.
- ✅ **CORS** with `AllowAnyOrigin` for development (restrict this in production).
- ✅ **Static files** so the Web API can also serve the built React app if needed.

```csharp
// filepath: WebApiAdaptor/Program.cs
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc().AddNewtonsoftJson(options =>
{
  options.SerializerSettings.ContractResolver = new DefaultContractResolver();
});

builder.Services.AddCors(options =>
{
  options.AddDefaultPolicy(policy =>
  {
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
  });
});

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors();

app.Run();
```

> 🔒 **Production CORS:** Replace `AllowAnyOrigin()` with `policy.WithOrigins("https://yourdomain.com")`.

### 3. Frontend – React Pivot Table

The React client lives in the `Client/` folder.

#### 3.1 Install npm dependencies

```bash
cd ../Client
npm install
```

#### 3.2 Verify the API URL

Open `src/App.tsx` and ensure the `url` in the `DataManager` points to your backend port (default in this repo: `5200`).

```tsx
// filepath: Client/src/App.tsx
import * as React from 'react';
import { PivotViewComponent, CellEditSettings } from '@syncfusion/ej2-react-pivotview';
import { DataManager, WebApiAdaptor } from '@syncfusion/ej2-data';
import type { DataSourceSettingsModel } from '@syncfusion/ej2-pivotview/src/model/datasourcesettings-model';
import type { BeginDrillThroughEventArgs } from '@syncfusion/ej2-pivotview';
import './App.css';

function App(): React.ReactElement {
    const data: DataManager = new DataManager({
        url: 'http://localhost:5200/api/Orders',   // 👈 Update this if your backend uses a different port
        adaptor: new WebApiAdaptor(),
        crossDomain: true
    });

    const editSettings: CellEditSettings = {
        allowEditing: true,
        allowAdding: true,
        allowDeleting: true,
        mode: 'Normal'
    };

    const dataSourceSettings: DataSourceSettingsModel = {
        dataSource: data,
        expandAll: false,
        rows: [{ name: 'CustomerID' }],
        columns: [{ name: 'OrderID' }],
        values: [{ name: 'Freight' }],
        formatSettings: [{ name: 'Freight', format: 'N0' }],
    };

    const pivotObj = React.useRef<PivotViewComponent>(null);

    function beginDrillThrough(args: BeginDrillThroughEventArgs) {
        for (var i = 0; i < args.gridObj.columns.length; i++) {
            if (args.gridObj.columns[i].field === "OrderID") {
                args.gridObj.columns[i].isPrimaryKey = true;
            } else {
                args.gridObj.columns[i].visible = true;
                if (args.gridObj.columns[i].field === 'OrderDate' || args.gridObj.columns[i].field === 'ShippedDate') {
                    args.gridObj.columns[i].editType = 'datetimepickeredit';
                }
            }
        }
    }

    return (
        <div className='control-section' style={{ margin: 100 }}>
            <PivotViewComponent
                ref={pivotObj}
                id='PivotView'
                height={350}
                width={700}
                beginDrillThrough={beginDrillThrough}
                editSettings={editSettings}
                dataSourceSettings={dataSourceSettings}>
            </PivotViewComponent>
        </div>
    );
}

export default App;
```

---

## ▶️ Running the Application

You need **two terminals** — one for the backend API and one for the React client.

### ▶️ Start the Backend (Terminal 1)

```bash
cd WebApiAdaptor
dotnet run
```

The API will start on a URL like `https://localhost:5200` (or `http://localhost:5200`).

**Verify it works:**

- 🌐 Open `https://localhost:5200/api/Orders` in your browser.
- ✅ You should see JSON in the format `{ Items: [...], Count: 45 }`.

> 📝 Note the port number in the terminal output and update `url` in `Client/src/App.tsx` if it is different from `5200`.

### ▶️ Start the Frontend (Terminal 2)

```bash
cd Client
npm run dev
```

The React app will open at `http://localhost:5173` by default (Vite dev server). 🎉

You should see the Pivot Table populated with aggregated **Freight** values, grouped by **CustomerID** (rows) and **OrderID** (columns).

### ✅ Verify in the Browser

1. Open the browser's **Developer Tools** (F12) → **Network** tab.
2. Reload the page.
3. You should see a GET request to `http://localhost:5200/api/Orders` with status `200` and a JSON response containing `Items` and `Count`.
4. The Pivot Table renders the aggregated data automatically.

---

## 🧪 Testing CRUD Operations

The Pivot Table supports full CRUD through its built-in **drill-through editing** grid.

| Step | Action                                                                                                  | Expected Network Request                                |
| ---- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------- |
| 1️⃣  | **Double-click** any pivot cell to open the drill-through grid showing underlying source records.       | Initial GET to `/api/Orders`                            |
| ➕ 2️⃣ | Click **Add**, fill in the new row fields, then click **Update**.                                       | `POST http://localhost:5200/api/Orders`                |
| ✏️ 3️⃣ | Click **Edit** on an existing row, change a field, then click **Update**.                                | `PUT http://localhost:5200/api/Orders`                 |
| 🗑️ 4️⃣ | Click **Delete** on a row to remove it.                                                                  | `DELETE http://localhost:5200/api/Orders/{OrderID}`    |
| 🔁 5️⃣ | The Pivot Table automatically refreshes to display the updated aggregated data from the backend.        | New GET to `/api/Orders`                                |

> 🔑 The `OrderID` column is automatically marked as the primary key inside the `beginDrillThrough` event, so update and delete operations know which record to target.

---

## 🔧 Troubleshooting

| ❓ Issue                                | 🔍 Symptom                                                                                                       | ✅ Resolution                                                                                                                |
| --------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- |
| 🚫 Empty Pivot Table                    | Pivot loads with no errors but no rows or values appear.                                                          | Ensure the API returns `{ Items, Count }` and that field names match the `dataSourceSettings` (case-sensitive).               |
| 404 Not Found                           | Network tab shows a 404 response when the Pivot Table loads.                                                     | Confirm the backend is running, the route is `[Route("api/[controller]")]`, and the URL in `App.tsx` matches the API port.     |
| 💥 500 Internal Server Error            | The Pivot Table fails and the browser shows a server error.                                                      | Check the terminal/Visual Studio output for stack traces. Common causes: null reference or serialization issues.             |
| 🌐 CORS Blocked                         | Console shows `Access to XMLHttpRequest ... has been blocked by CORS policy`.                                    | Verify CORS is configured in `Program.cs` and `app.UseCors()` is called **before** `app.MapControllers()`.                     |
| 💾 CRUD operations not saving           | The edit dialog closes but changes are not reflected in the data.                                                | Confirm the primary key is set in `beginDrillThrough` and the backend routes match the WebApiAdaptor defaults (POST/PUT/DELETE). |
| 🔤 Property casing mismatch             | Pivot appears empty or shows "field not found" even though the API returns data.                                 | Ensure `DefaultContractResolver` is registered in `Program.cs` so PascalCase fields like `OrderID` are preserved.             |
| 🐢 Pivot Table loads slowly             | Rendering is sluggish or the browser hangs.                                                                      | Make sure the `Count` field is returned so paging/virtual scrolling can be enabled.                                          |
| 🔒 SSL/TLS certificate error            | Console shows `net::ERR_CERT_AUTHORITY_INVALID` or browser warns about an untrusted certificate.                 | Run `dotnet dev-certs https --clean` then `dotnet dev-certs https --trust` (Windows/macOS). On Linux, use HTTP for local testing. |

---

## 📖 API Reference

The backend exposes the following endpoints through `OrdersController`:

| Method     | Route              | Purpose                                       | Request Body                  | Response            |
| ---------- | ------------------ | --------------------------------------------- | ----------------------------- | ------------------- |
| `GET`      | `/api/Orders`      | Retrieve all order records                    | —                             | `{ Items, Count }`  |
| `POST`     | `/api/Orders`      | Insert a new order                            | `OrdersDetails` JSON          | `200 OK` / `204`    |
| `PUT`      | `/api/Orders`      | Update an existing order (matched by `OrderID`) | `OrdersDetails` JSON        | `200 OK` / `204`    |
| `DELETE`   | `/api/Orders/{key}`| Remove an order by primary key                | —                             | `200 OK` / `204`    |

The `OrdersDetails` model exposes the following fields:

| Field         | Type        | Description                                |
| ------------- | ----------- | ------------------------------------------ |
| `OrderID`     | `int?`      | Unique order identifier (primary key)      |
| `CustomerID`  | `string?`   | Identifier of the customer                 |
| `EmployeeID`  | `int?`      | Identifier of the handling employee        |
| `Freight`     | `double?`   | Shipping cost                              |
| `ShipCity`    | `string?`   | Destination city                           |
| `Verified`    | `bool?`     | Whether the order is verified              |
| `OrderDate`   | `DateTime`  | Date the order was placed                  |
| `ShipName`    | `string?`   | Recipient name                             |
| `ShipCountry` | `string?`   | Destination country                        |
| `ShippedDate` | `DateTime`  | Date the order was shipped                 |
| `ShipAddress` | `string?`   | Full shipping address                      |

---

## 🤝 Contributing

Contributions are welcome and appreciated! 💖

1. 🍴 **Fork** the repository.
2. 🌿 **Create** a feature branch: `git checkout -b feature/my-awesome-change`
3. 💾 **Commit** your changes: `git commit -m "Add my awesome change"`
4. 📤 **Push** to your branch: `git push origin feature/my-awesome-change`
5. 🔁 **Open** a Pull Request describing the change and its motivation.

### 📋 Contribution Guidelines

- Follow the existing code style in both the React and ASP.NET Core projects.
- Keep changes focused — one feature or fix per pull request.
- Update or add documentation (`README.md`, `webapi-adaptor.md`) when behavior changes.
- Test your changes locally against both the backend and frontend before submitting.

---

## 📜 License & Support

### 📄 License

This project is released under the **MIT License**. You are free to use, modify, and distribute the code in personal and commercial projects. See the [LICENSE](LICENSE) file for full text.

### 🛟 Support

- 📘 **Documentation:** [Syncfusion® React Pivot Table Docs](https://ej2.syncfusion.com/react/documentation/pivotview/getting-started)
- 💬 **Community forum:** [Syncfusion® Community](https://www.syncfusion.com/forums)
- 🐛 **Bug reports & feature requests:** [GitHub Issues](https://github.com/SyncfusionExamples/webapi-adaptor-with-pivot-table/issues)
- 📧 **Direct support:** [Syncfusion® Support Portal](https://www.syncfusion.com/support) (for licensed users)
- 📖 **Web API Adaptor Guide:** [WebApiAdaptor Documentation](https://ej2.syncfusion.com/react/documentation/data/adaptors/webapi-adaptor)

> ⭐ If this project helped you, please consider giving it a **star** on GitHub — it helps others discover it!

---

## 📚 Related Resources

- 🔗 [UrlAdaptor with Pivot Table](https://github.com/SyncfusionExamples/url-adaptor-with-pivot-table) — Companion sample using `UrlAdaptor` instead of `WebApiAdaptor`.
- 📘 [PivotTable Data Binding](https://ej2.syncfusion.com/react/documentation/pivotview/data-binding)
- 📘 [DataManager Getting Started](https://ej2.syncfusion.com/react/documentation/data/getting-started)
- 📘 [WebApiAdaptor Reference](https://ej2.syncfusion.com/react/documentation/data/adaptors/webapi-adaptor)
- 📘 [PivotTable Editing](https://ej2.syncfusion.com/react/documentation/pivotview/editing)
- 📘 [PivotTable Drill-Through](https://ej2.syncfusion.com/react/documentation/pivotview/drill-through)

---

<div align="center">
  <sub>Built with ❤️ using <a href="https://react.dev/">React</a> and <a href="https://dotnet.microsoft.com/">.NET</a> by the <a href="https://www.syncfusion.com/">Syncfusion®</a> team.</sub>
</div>
