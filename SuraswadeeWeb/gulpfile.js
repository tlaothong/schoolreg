'use strict';
 
var gulp = require('gulp');
var sass = require('gulp-sass');
 
gulp.task('sass', function () {
  gulp.src('./Content/*.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(gulp.dest('./Content'));
});
 
gulp.task('sass:watch', function () {
  gulp.watch('./Content/*.scss', ['sass']);
});