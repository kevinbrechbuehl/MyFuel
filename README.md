# MyFuel

✨ This is the [Nx workspace](https://nx.dev) for my fuel tracker. I am aware that the architecture for this simple
application is quite over-engineered. However, I also use this code as a playground to try out and test new ideas and
concepts.

## Prerequisites

Be sure to have the following prerequisites installed:

- [Node.js LTS](https://nodejs.org/)
- [.NET 8 SDK](https://dotnet.microsoft.com/)

Run the following command in the repository root to install dependencies:

```sh
npm install
```

## Local Development

Run the following command to start both the frontend and the backend:

```sh
npx nx run-many -t serve -p frontend backend
```
