module.exports = {
  outputDir: '../wwwroot',
  chainWebpack: config => {
    // Prevent HMR nuking the console.
    config.plugin('friendly-errors')
      .tap(args => {
        return [{
          ...args,
          clearConsole: false
        }]
      })
  },
  devServer: {
    // Hide the progress bar during HMR.
    progress: false,
    // This port should match the ASP development port.
    proxy: {
      '^/api': {
        target: 'http://localhost:5207'
      },
    }
  }
}
