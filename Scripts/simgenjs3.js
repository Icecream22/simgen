/**
 *
 * @authors Your Name (you@example.org)
 * @date    2017-08-24 22:09:05
 * @version $Id$
 */
$(document).ready(function () {     /*ready*/
                /*top-search 搜索框的响应式变化 start*/

                /*按enter键搜索*/
                function search() {
                    alert("搜索成功！（待完成）");
                    //window.location.href = "http://www.cnblogs.com/jimchxi/archive/2009/03/11/1408483.html";
                }
                $("#top-search").keydown(function (event) {     /*按enter键搜索*/
                    if (event.which == "13")
                        search();
                });
                /*按enter键搜索*/


                /*一开始打开检测窗口宽度并设置样式*/
                var winWidthFirst = $(window).width();
                if (winWidthFirst >= 500) {
                    $("#logo-wrapper").css({ "width": "155px", "height": "36px", "margin": "24px 0 24px 20px" });
                    $("#top-search").css({ "width": "120px" });
                }
                else if (0 < winWidthFirst < 500) {
                    $("#logo-wrapper").css({ "width": "100px", "height": "24px", "margin": "30px 0" });
                    $("#top-search").css({ "width": "89px"});
                }
                $("#top-search").focus(function () {
                    var winWidthSecond = $(window).width();
                    if (winWidthSecond >= 500) {
                        $("#top-search").css({ "width": ((winWidthSecond - 155) * 0.5)});
                    }
                    else if (0 < winWidthSecond < 500) {
                        $("#top-search").css({ "width": "89px"});
                    }
                    $(window).resize(function () {
                        var winWidth1 = $(window).width();
                        if (winWidth1 >= 500) {
                            $("#top-search").css({ "width": ((winWidth1 - 155) * 0.5)});
                        }
                        else if (0 < winWidth1 < 500) {
                            $("#top-search").css({ "width": "89px"});
                        }
                    });
                });
                $("#top-search").blur(function () {
                    var winWidthThird = $(window).width();
                    if (winWidthThird >= 500) {
                        $("#top-search").css({ "width": "120px"});
                    }
                    else if (0 < winWidthThird < 500) {
                        $("#top-search").css({ "width": "89px"});
                    }
                    $(window).resize(function () {
                        var winWidth2 = $(window).width();
                        if (winWidth2 >= 500) {
                            $("#top-search").css({ "width": "120px"});
                        }
                        else if (0 < winWidth2 < 500) {
                            $("#top-search").css({ "width": "89px"});
                        }
                    });
                });
                /*一开始打开检测窗口宽度并设置样式*/


                /*!窗口大小变化时!!!，样式变化*/
                $(window).resize(function () {
                    var winWidth = $(window).width();
                    if (winWidth >= 500) {
                        $("#logo-wrapper").css({ "width": "155px", "height": "36px", "margin": "24px 0 24px 20px" });
                        $("#top-search").css({ "width": "120px"});
                    }
                    else if (0 < winWidth < 500) {
                        $("#logo-wrapper").css({ "width": "100px", "height": "24px", "margin": "30px 0" });
                        $("#top-search").css({ "width": "89px"});
                    }
                });
                /*!窗口大小变化时!!!，样式变化*/

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
