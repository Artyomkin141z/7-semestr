const gulp = require('gulp'); 
const concat = require('gulp-concat');

gulp.task('scripts', function() {
    console.log("start");
    return gulp.src(['./1.js', './2.js', './3.js'])
        .pipe(concat('concat.js'))
        .pipe(gulp.dest('.concat/'))
});