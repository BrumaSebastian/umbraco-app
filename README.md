# UmbracoDev

Short presentation of the project and how the custom Tailwind CSS generator works.
My main focus for this project was creating a customizable interface using Umbraco Backoffice structure to generate tailwindcss on the fly.

## Overview

UmbracoDev.Web is a Razor Pages website built on .NET 9 and Umbraco 15.3. It includes a custom Tailwind CSS generator that builds a project-specific Tailwind stylesheet from design tokens configured in the Umbraco backoffice.

## Key features

- Umbraco 15.3 + .NET 9 (Razor Pages)
- Custom Tailwind CSS generator that produces a single generated stylesheet used by the frontend (wwwroot/css/tailwind.css).
- Exposes design tokens in the backoffice so content editors can control:
  - Padding, gap, margin (spacing utilities)
  - Background color and text color
  - Both predefined palette colors and custom color values
- Instant frontend updates after regenerating the stylesheet (refresh required in the browser).

## Where to look in the codebase

- Generated stylesheet: wwwroot/css/tailwind.css
- Frontend scripts controlling theme: wwwroot/js/
- The generator and backoffice integration live in the web project (search for "tailwind", "generator", or backoffice config types in the UmbracoDev.Web project).

## How it works (high level)

1. Editors set design tokens (spacing values and colors) using a custom settings area in the Umbraco backoffice.
2. The project reads those settings and runs a generator that outputs a tailored Tailwind CSS file containing only the utilities needed for the configured tokens.
3. The generated CSS is consumed by the Razor Pages frontend to style components consistently.

## Notes

This project is a simplified example and may not cover all edge cases or production-ready features.
It's intended to demonstrate the concept of integrating Tailwind CSS with Umbraco and .NET.

## Presentation

CMS capabilities of changing design tokens in the backoffice and instantly seeing the changes reflected on the frontend:

https://github.com/user-attachments/assets/e28bc74a-642c-4c2b-a79f-d9547f1d9bec

Changing theme colors in the backoffice choosing from the predefined colors:

https://github.com/user-attachments/assets/428c364b-2876-4655-a9a6-475a91646d3a

Changing theme colors in the backoffice choosing custom colors:

https://github.com/user-attachments/assets/2ccb08c8-49fd-43c9-a2ea-d76addc4e38a

Application overview:

https://github.com/user-attachments/assets/0fbf93b3-4b24-43ab-a9f2-c5db37f935ea

## Instalation

1. Clone the repository
2. Open the solution in Visual Studio
3. Create a new SQL database and update the connection string in `appsettings.json`
4. Run the application
5. Complete the Umbraco installation wizard
6. Navigate to the "Settings" section, then to "Synchronisation", uSync and press "Import" under "Everything" section. **Note**: images are not included as they are saved only in the database.
7. Navigate to homepage.

For the tailwindcss generator to work, run the 'npm run build:css' at the root of the project

## Tailwind css generator

This integration connects Umbraco component properties to Tailwind CSS utility classes, enabling flexible, CMS-driven styling while keeping the Tailwind build process intact.

1. Property Mapping

Each Umbraco property is mapped to a specific Tailwind utility.
For example:

twPaddingTop → pt-[value]

twMarginBottom → mb-[value]

These mappings are handled in the **TailwindClassBuilderHelper.cs** class, which converts property values defined in Umbraco into valid Tailwind class names.

2. Dynamic Class Collection

All Tailwind classes generated through these mappings are collected and written to a JSON file at:

```
  /Styles/data.json
```

This file acts as a registry of every dynamically generated class used across Umbraco components.

3. Tailwind Compilation

Tailwind CSS uses a content scanning process to determine which CSS utilities to include in the final stylesheet.
It only generates CSS for class names it finds within the project files (e.g., .cshtml, .ts, .json, etc.).

Because these dynamic class names don’t exist directly in the source code, they need to be stored in a file that Tailwind can scan. By including them in Styles/data.json, we ensure that Tailwind’s build process detects and compiles all necessary styles into:
```
  /wwwroot/css/tailwind.css
```

4. Why data.json Is Important

Without this step, Tailwind would purge unused classes (since it never “sees” the dynamically generated names), and the resulting CSS wouldn’t include the expected styling.
By centralizing all generated class names into data.json, we give Tailwind a reliable source to read from, ensuring that every Umbraco-driven style is properly compiled.

<img width="1919" height="1080" alt="image" src="https://github.com/user-attachments/assets/e868f6fc-78b8-4e18-b6a1-5af3133c6a65" />
<img width="1919" height="1080" alt="image" src="https://github.com/user-attachments/assets/146e9e9e-195b-42d1-97f5-38b69a009217" />


