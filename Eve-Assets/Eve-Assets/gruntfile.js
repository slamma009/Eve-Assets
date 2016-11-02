module.exports = function (grunt) {

    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        watch: {
            js: {
                files: ['App/**/*'],
                tasks: ['includeSource']
            }
        },
        includeSource: {
            options: {
                basePath: 'App',
                baseUrl: '/'
            },
            myTarget: {
                files: {
                    'Index.html': 'App/Index-before.html'
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-include-source');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.registerTask('default', ['includeSource']);
}