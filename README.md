# ASP .NET 6 with Vue Hot Reload

This project template demonstrates how to setup ASP .NET 6 with Vue.js, enabling Hot Module Reloading. Essentially combining the boilerplate ASP.NET and [Vite](https://vitejs.dev/) with improved interoperability between the two.

To use, clone the current repo and run `dotnet new -i .` from the root directory. This will install the template into your local dotnet templates. You can then run `dotnet new vuehotreload -o "ProjectName` to create a new project, replacing "ProjectName" with the name of your project.

After creating the project, navigate to the client folder and run `npm install` to install the frontend dependencies. 

## Running

Run the solution as you would any other ASP.NET project. 

The `npm run serve` command will be spawned in the same console window as ASP.NET, merging the output of both. The `vite.config.js` file has been configured to proxy all calls from the /api endpoint to the ASP.NET backend.

Once running, navigate to http://localhost:3000/ and you should see the Vue boilerplate UI. http://localhost:3000/api/test will return the response from a test endpoint from the ASP.NET backend.

On Rider, stopping the application will stop both the ASP.NET and Vite processes. In Visual Studio you will need to manually stop the Vite process. 

## Deploying

On deploy, Vite will generate the output to the wwwroot directory and copied to the final deployment location. The wwwroot directory will be cleaned before deployment. A folder deploy is included in the project.

## Configuring

For simplicity this solution is setup with JavaScript and Vue 3. Vite works out of the box TypeScript and, with some setup, Vue 2. Feel free to make modifications to your suiting.

If you run your ASP.NET application on a different port, you will need to update the `vite.config.js` file to reflect this.

## vue-cli

Originally this repo used Vue CLI as the frontend, you can still find that setup under the [vue-cli branch](https://github.com/rmp135/ASPVueHotReload/tree/vue-cli).
