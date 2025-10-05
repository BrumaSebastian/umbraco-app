# UmbracoDev.Web

Short presentation of the project and how the custom Tailwind CSS generator works.

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

Changing theme colors in the backoffice choosing custom colors:

Application overview:

## Instalation

1. Clone the repository
2. Open the solution in Visual Studio
3. Create a new SQL database and update the connection string in `appsettings.json`
4. Run the application
5. Complete the Umbraco installation wizard
6. Navigate to the "Settings" section, then to "Synchronisation", uSync and press "Import" under "Everything" section. **Note**: images are not included as they are saved only in the database.
7. Navigate to homepage.

For the tailwindcss generator to work, run the 'npm run build:css' at the root of the project
