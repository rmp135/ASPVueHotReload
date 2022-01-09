# ASP .NET 6 with Vue Hot Reload

This solution demonstrates how to setup ASP .NET 6 with Vue.js, enabling Hot Module Reloading. Essentially combining the boilerplate ASP.NET and Vue CLI with improved interoperability between the two.

After cloning the repo, navigate to the client folder and run `npm install` to install the frontend dependencies.

## Running

When running the solution, the `npm run serve` command will be spawned in the same console window as ASP.NET, merging the output of both. The `vue.config.js` file has been configured to proxy all calls from the /api endpoint to the ASP.NET backend.

Once running, navigate to http://localhost:8080/ and you should see the Vue boilerplate UI. http://localhost:8080/api/test will return the response from a test endpoint from the ASP.NET backend.

Closing the console window will stop both the ASP.NET and Vue CLI processes. 

# Deploying

On deploy, the Vue CLI generated files will be output to the wwwroot directory and copied to the final deployment location. 

## Modifying

If you wish to generate a different Vue CLI application, you can do so.
 
- Delete the "client" folder.
- Open the project root folder in the command line. 
  - Type `vue create client` and follow the prompts.
- Copy the `vue.config.js` from this repo to the newly created client folder.