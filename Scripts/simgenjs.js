/**
 *
 * @authors Your Name (you@example.org)
 * @date    2017-08-19 20:33:33
 * @version $Id$
 */
    $(document).ready(function () {     /*ready*/
                function search() {
                    alert("搜索成功！（待完成）");
                    //window.location.href = "http://www.cnblogs.com/jimchxi/archive/2009/03/11/1408483.html";
                }

                /*top-search 搜索框的响应式变化 start*/
                var winWidthFirst = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;

                if ( winWidthFirst >= 430) {  /*窗口宽度大于400*/
                    $("#top-search").focus(function () {    /*鼠标点击搜索框*/
                        /*先点击后检测，这样比较好，会随窗口变化而变化*/
                        var winWidth = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
                        if ( winWidth >= 500) {
                            $("#top-search").css({ "width": ((winWidth - 155) * 0.5)});
                            $("#top-search").blur(function () {   /*鼠标不落在搜索框*/
                                $("#top-search").css({ "width": "120px"});
                            });
                        }
                        else if( 430 <= winWidth < 500){
                            $("#top-search").css({ "width": "120px"});
                            $("#top-search").blur(function () {   /*鼠标不落在搜索框*/
                                $("#top-search").css({ "width": "120px"});
                            });
                        }

                        $("#top-search").keydown(function (event) {     /*要在按到搜索框的时候才检测回车键时候搜索，电脑上可用，手机端呢*/
                            if (event.which == "13")
                                search();
                        });
                    });

                }
                else if (0 < winWidthFirst < 430) {     /*窗口宽度小于400*/
                    $("#logo-wrapper").css({ "width": "100px", "height": "24px" ,"margin":"30px 0"});
                    $("#top-search").css({ "width": "50px"});
                    $("#top-search").keydown(function (event) {     /*要在按到搜索框的时候才检测回车键时候搜索，电脑上可用，手机端呢*/
                        if (event.which == "13")
                            search();
                    });
                }
                /*top-search 搜索框的响应式变化  end*/

                /*标题栏点击下划线效果 start*/  /*!!!在每个页面，比如index 和 product的select 下面还要再加相应的$("#nav-home").addClass("doc-set-nav-tab-border"); or $("#nav-product").addClass("doc-set-nav-tab-border");*/
                /*没用的玩意儿，暂时显示好玩用*/
                $("#nav-home").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-home").addClass("doc-set-nav-tab-border");
                });
                $("#nav-product").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-product").addClass("doc-set-nav-tab-border");
                });
                $("#nav-techdoc").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-techdoc").addClass("doc-set-nav-tab-border");
                });
                $("#nav-promotion").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-promotion").addClass("doc-set-nav-tab-border");
                });
                $("#nav-download").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-download").addClass("doc-set-nav-tab-border");
                });
                $("#nav-salenet").click(function () {
                    $("#nav ul li").removeClass("doc-set-nav-tab-border");
                    $("#nav-salenet").addClass("doc-set-nav-tab-border");
                });
                /*标题栏点击下划线效果 end*/

                /*header-hidden-mask蒙版及缩小标题栏相关 start*/
                $("#top-hide-tabs").click(function () {
                    $(".header-hidden-mask").css({ "display": "block" });
                    $(".header-hidden-nav-wrapper").css({ "display": "block" });
                    $(".header-hidden-mask").click(function () {
                        $(".header-hidden-mask").css({ "display": "none" });
                        $(".header-hidden-nav-wrapper").css({ "display": "none" });
                    });
                });
                /*header-hidden-mask蒙版及缩小标题栏相关 end */
                });
