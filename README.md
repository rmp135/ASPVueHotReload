# ASP .NET 6 with Vue Hot Reload

This project template demonstrates how to setup ASP .NET 6 with Vue.js, enabling Hot Module Reloading. Essentially combining the boilerplate ASP.NET and [Vite](https://vitejs.dev/) with improved interoperability between the two.

To use, download the folder as a zip file and place it in your user project templates folder. On Windows this is `%userprofile%\Documents\Visual Studio 2022\Templates\ProjectTemplates\C#` for VS2022.

After cloning the repo, navigate to the client folder and run `npm install` to install the frontend dependencies.

## Running

When running the solution, the `npm run serve` command will be spawned in the same console window as ASP.NET, merging the output of both. The `vite.config.js` file has been configured to proxy all calls from the /api endpoint to the ASP.NET backend.

Once running, navigate to http://localhost:3000/ and you should see the Vue boilerplate UI. http://localhost:3000/api/test will return the response from a test endpoint from the ASP.NET backend.

Closing the console window will stop both the ASP.NET and Vite processes. 

## Deploying

On deploy, Vite will generate the output to the wwwroot directory and copied to the final deployment location. The wwwroot directory will be cleaned before deployment.

## Configuring

For simplicity this solution is setup with JavaScript and Vue 3. Vite works out of the box TypeScript and, with some setup, Vue 2. Feel free to make modifications to your suiting.

## vue-cli

Originally this repo used Vue CLI as the frontend, you can still find that setup under the [vue-cli branch](https://github.com/rmp135/ASPVueHotReload/tree/vue-cli).
