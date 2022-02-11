# ASP .NET 6 with Vue Hot Reload

This solution demonstrates how to setup ASP .NET 6 with Vue.js, enabling Hot Module Reloading. Essentially combining the boilerplate ASP.NET and Vite with improved interoperability between the two.

After cloning the repo, navigate to the client folder and run `npm install` to install the frontend dependencies.

## Running

When running the solution, the `npm run serve` command will be spawned in the same console window as ASP.NET, merging the output of both. The `vite.config.js` file has been configured to proxy all calls from the /api endpoint to the ASP.NET backend.

Once running, navigate to http://localhost:3000/ and you should see the Vue boilerplate UI. http://localhost:3000/api/test will return the response from a test endpoint from the ASP.NET backend.

Closing the console window will stop both the ASP.NET and Vite processes. 

## Deploying

On deploy, Vite will generate the outputto the wwwroot directory and copied to the final deployment location. The wwwroot directory will be cleaned before deployment.
