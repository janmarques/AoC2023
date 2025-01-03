﻿//using AoC2023;
//using System;
//using System.Linq;
//using System.Numerics;
//using System.Reflection.Metadata;
//using System.Runtime.Intrinsics.Arm;
//using System.Security.Cryptography;
//using System.Text;
//using System.Xml.Linq;

//var fullInput =
//@"kbr{x>2309:A,R}
//rp{a>2160:mcm,m<3139:bz,fs}
//hqr{a>3048:R,x>1298:R,R}
//ht{s<1042:A,a<3744:A,a>3879:lb,zsj}
//hkl{x<2690:xps,gsq}
//bvk{s<464:R,x>1190:R,a<3443:A,A}
//mj{a<725:R,R}
//kph{s<385:A,A}
//vr{x>1596:xt,nk}
//hc{m<999:A,x<224:R,R}
//bp{a>1785:msj,sk}
//fs{a<1989:A,x>561:kdv,x>192:A,R}
//nls{x>3679:R,s<1583:A,s<1669:A,A}
//gsq{a>1760:A,A}
//phd{a<187:R,a>307:A,s>2783:A,A}
//nb{s<238:A,R}
//rs{x<2853:cd,a<1366:pxm,m>2215:cfp,bpt}
//cvn{m>1940:tb,s<421:tmg,s>560:nnq,A}
//fh{x<264:tf,hvg}
//kl{x>382:R,s>1772:R,s>1604:R,R}
//hz{s<1084:A,A}
//sdm{x<725:hpj,bd}
//xm{s<1235:vbs,s>1363:A,mh}
//xb{m<1640:jn,x<3607:A,pnq}
//zlj{a>3273:A,x<1274:A,R}
//bd{x<755:vc,cz}
//qdv{x<350:cgv,s<2917:zrb,kks}
//qsc{s>301:xs,a<1732:R,m<3313:A,A}
//rt{x<160:A,s>2931:R,R}
//dzm{m<1790:R,m<1939:A,s>2295:A,A}
//zsx{a>2296:xfj,jbd}
//lk{s<2027:A,s<2291:R,x<1237:lm,A}
//hhp{a<3101:A,x>557:R,s>152:A,A}
//rkj{a>1490:R,a<1422:A,R}
//tbp{a<718:R,s<506:A,R}
//ph{x>674:R,m>1561:A,m>837:A,R}
//vf{a>919:R,a>599:kv,a<251:sh,npj}
//tmz{x<129:R,x>158:R,R}
//hzx{x>1485:R,A}
//xzr{m<2651:R,a<691:A,A}
//tz{s<2170:cdv,x>619:skb,a<2380:krh,qz}
//nfs{a<1850:R,x>2485:A,R}
//tbx{x<2370:tgp,a<1359:nsd,x>2467:bhj,lxg}
//ffd{a<642:R,a<845:hfj,R}
//jgb{m<3251:R,s<224:R,m>3513:R,A}
//lc{x<2011:R,x<2110:R,R}
//dnk{m>3033:A,A}
//fhq{a>1557:A,s<3161:rkj,s>3607:djm,ggh}
//glk{m>2388:rt,gcb}
//kb{m>2412:jnq,x<266:A,vq}
//tq{m<1435:A,A}
//tff{s<279:R,A}
//nz{s<335:fvn,a<358:mpp,s>587:xd,jqc}
//vc{x>735:R,a<2284:R,s<3520:R,R}
//scf{s>2746:R,x<82:R,s<2408:R,R}
//sv{m<773:st,ln}
//dq{m<881:xrl,m<1325:psz,hht}
//krd{x<412:R,s<163:A,x<656:A,A}
//hcv{s<444:A,m>2682:R,x>647:R,R}
//jnq{x>246:R,m>3033:A,s<2629:A,R}
//jmr{x>522:R,x>316:A,s>787:A,R}
//zqq{m<1496:A,x<112:A,R}
//vbs{m<1219:R,s>1032:R,s>919:R,A}
//dlv{s<707:A,a<446:A,s>741:kc,R}
//lt{x<3238:R,x<3353:A,zg}
//glh{a<1492:pgv,hd}
//ds{s<610:A,R}
//bvz{a<3024:nzm,a<3669:shb,m<1829:jxg,A}
//tl{s>3142:R,s<2376:bq,x<1364:A,qt}
//zn{m>2958:tk,bs}
//pvd{x>2669:R,A}
//tp{a<2819:bh,gvz}
//zv{s<619:km,R}
//xgs{a<1906:A,x<2055:A,R}
//vcd{x>3711:A,x>3578:A,A}
//djq{s<1657:R,m>2805:A,zkl}
//kt{m<2476:xkv,a<672:htv,s<809:qx,rq}
//xph{s<719:A,m>2904:R,R}
//ntq{a>3393:R,s<606:cfc,hk}
//xq{m>1452:R,a>1510:A,A}
//zb{s<2772:R,A}
//kv{s<2620:A,s<2650:A,R}
//ksd{x>2528:R,rxz}
//tf{a<1047:stx,m<2657:js,pcb}
//dcf{x>397:A,x<367:A,R}
//gs{x>545:R,R}
//nv{m<2534:R,x>1297:A,m<3435:dc,dsh}
//dhz{x<579:A,m<3496:R,a>1496:R,A}
//rpk{a<3529:R,x>2673:R,m<3343:A,A}
//vrk{s<746:xph,s<771:nhf,jmr}
//jtb{x>2319:R,a<856:R,kbr}
//bnd{x>355:R,R}
//cfc{m>2900:R,A}
//hvg{x<356:A,a>1092:fj,s<451:A,A}
//xfj{x>659:jnv,s<2767:kj,s<2843:A,R}
//xj{s>3265:R,x<1251:R,a>3192:A,A}
//kzf{m<2460:R,s<1082:tqp,a>2659:dcr,A}
//bnm{m<3230:gz,a>843:dhz,vbz}
//jn{s>2515:R,A}
//hb{m>2503:ttf,a>3916:A,qj}
//rq{s<1167:xfg,s<1386:R,x<3821:nls,R}
//rv{x<2349:zpb,a<1231:zfm,R}
//djm{x<3262:R,A}
//xl{m<1184:R,x<3556:A,A}
//zgq{s<282:gsh,cr}
//sl{m>2629:A,s<474:A,R}
//ng{s>3324:A,s<3091:R,s<3190:R,R}
//vcg{x<3570:A,m>2628:R,m<2092:dzm,R}
//kfk{m>2016:A,xlq}
//pbc{a<2609:rp,kcl}
//srl{x<57:R,x<100:A,m<3346:A,R}
//srv{s<406:A,x>212:R,s>607:A,A}
//hpj{a>2644:qrd,A}
//lzx{x>2233:R,A}
//dxc{m>616:hkn,s>2680:cld,x>566:vf,jfh}
//zrt{s>2756:A,R}
//cr{m>3260:R,gkr}
//sd{a<2207:jq,a<3385:kzf,x>1721:ht,nv}
//vs{x<451:R,R}
//qpr{m>3272:vs,fkm}
//shb{m<2618:R,m<3334:R,A}
//rlc{x<305:R,x>321:R,m>3127:A,A}
//qj{x>2660:A,x>2348:R,m<884:A,R}
//djd{x<2495:gfs,htj}
//hht{a>3137:A,x<649:R,A}
//pr{m<662:R,R}
//tsf{m<1703:A,a<1358:R,A}
//lz{a<952:R,A}
//gv{a>3238:R,x>453:A,s<2711:R,R}
//pfr{s>2525:A,a>1108:A,A}
//kmq{x>392:zn,jb}
//hn{s<1515:xm,kl}
//np{a>2419:A,m>553:A,A}
//nr{a>3070:xgb,ngg}
//ktg{s>2571:A,A}
//qvh{a>2488:R,a>918:A,A}
//stx{s>289:A,x>91:R,s<156:A,R}
//hqd{a<632:A,x>2009:A,A}
//nm{s<1745:R,A}
//pzh{m<2360:md,m>2979:rqr,s>2988:br,krv}
//zrb{s<2528:tz,m>1549:zsx,a<1491:dxc,dq}
//llb{m<1107:djz,s>300:R,A}
//cgv{a>1941:glk,x>147:zs,m<1869:gqf,vk}
//xrl{s>2706:A,m<561:hnr,m>748:A,knh}
//xfg{x>3831:R,a<978:A,A}
//vdf{s>3024:A,a>840:A,R}
//tmg{m<1656:R,a<1767:A,x>696:R,A}
//tjs{a>431:R,A}
//nl{s>3402:A,s<3260:R,R}
//jtq{a>2199:nr,qd}
//jjq{s>2520:xj,m<713:rm,m<1281:R,hqr}
//mv{s>2678:A,x>2760:A,R}
//rrn{m>772:A,A}
//ngg{a<2529:gmf,x>3082:cvp,tp}
//bkr{m<3088:rfh,R}
//tgp{x<2296:pqx,x<2337:jtb,rv}
//ncf{x>196:R,s<2752:R,A}
//vp{m<2026:A,A}
//fx{s>1162:cl,df}
//hr{m>954:hn,spf}
//nnq{a<1542:A,R}
//tdn{x<2514:R,s<646:R,A}
//gqf{a<707:hh,m>956:ldg,nxv}
//mkt{s>727:sd,a>2466:rmg,a<988:rl,bp}
//nzb{x<2686:R,a<1081:A,x<2792:A,A}
//js{a<1188:R,R}
//lm{x>1189:R,x>1176:A,A}
//vz{x<3651:R,x>3854:R,R}
//bqq{x>1279:R,s>3370:R,x>1202:A,R}
//snv{x<194:A,x<252:A,a>235:A,R}
//msv{a<592:A,a<707:A,A}
//stg{s>1846:R,x<683:R,m>2553:R,A}
//rl{m>1908:hns,s<321:pkh,ffd}
//nnd{m<2005:A,A}
//zpb{s>591:A,R}
//jnv{m>2507:A,s<2765:A,x>797:A,A}
//llz{a<835:R,x>406:A,x<377:R,A}
//pcb{x>174:R,m<2756:R,R}
//br{m<2580:flb,qvh}
//qjd{m>2397:A,R}
//qp{x<1157:pzh,m>1748:vg,x<1398:khk,kh}
//rnl{x>1385:R,zlj}
//bq{x<1438:A,m<3141:A,R}
//zts{a<1415:A,s<3560:R,A}
//qgk{s>3620:A,m<2494:A,m>2665:A,A}
//zqp{s>252:A,s<96:cm,s<186:hhp,R}
//kmr{a<517:A,A}
//nt{a>419:msv,phd}
//ltc{s<1274:zxr,djq}
//psc{x<2433:ds,s>848:R,s>450:fln,nb}
//nx{m>3177:R,lqj}
//hk{m>2677:R,m<2443:A,a>3006:R,R}
//rmg{x>1381:nq,m>2136:rh,bvk}
//pgv{x<834:ng,s>3456:R,hjb}
//klc{s<3005:A,A}
//zqh{s<615:A,x<2462:A,R}
//skb{x<758:ph,R}
//kx{s>2301:R,m<2849:R,x<1374:A,R}
//rqr{a<1696:pfr,s>2777:tjr,A}
//lcb{m<2118:jlx,a<1059:bsn,qsc}
//nsd{s<1091:pb,a>537:bls,tjx}
//pm{s>2902:R,x>1045:A,m>1491:R,A}
//sh{m>253:A,s<2613:A,m>142:R,A}
//rm{a>2840:R,a<2326:A,R}
//gxt{x>1879:rb,rc}
//jr{x>741:vj,a>953:tqv,pf}
//ff{x>2969:tkk,s<1319:jrk,A}
//qln{m>1728:R,a<1590:R,R}
//lqj{x<3660:A,x>3863:A,m>2633:A,R}
//fkm{x<568:R,x>719:A,A}
//xx{m>2490:A,x<698:A,s>2025:A,A}
//pf{m>2515:hcv,s>402:R,R}
//jl{s<3095:A,m>869:A,s>3684:A,bqq}
//qn{s<2335:mdr,x<3486:tmt,ct}
//jhq{a<2243:R,A}
//pkz{a<433:R,a>626:xzr,qm}
//mh{m>1320:R,A}
//mdb{s>542:R,m<3263:A,s<470:A,nxf}
//kjt{s<535:A,snv}
//ghz{x>1739:xq,tsf}
//hkg{s<304:R,m<1547:R,a>1657:R,R}
//pxm{a>814:zz,nt}
//prj{a>701:A,x>1692:R,A}
//qx{a>892:A,tpq}
//rfh{x<454:A,a<312:R,m<2607:R,R}
//tjr{a<2795:R,m<3541:A,s<3569:A,A}
//vh{s<1511:mkt,x<1652:qp,gxt}
//bl{m<2507:R,m>2724:R,m>2641:R,A}
//mth{x<434:R,A}
//zs{a<784:pkz,m<1476:jnf,kb}
//xh{x>252:rhs,hs}
//jdb{s>725:pll,x<3603:sp,kfk}
//nq{a<3114:R,x<1891:vv,sl}
//jtn{a<3768:R,m>1211:A,s<1261:R,R}
//ll{s<1434:R,A}
//zc{m<2298:gk,a>1836:pbc,a<679:nz,mrs}
//nrx{x>512:cvn,pht}
//jp{m>3379:A,s<2764:kx,mhk}
//dtm{a<2310:jhq,x>3498:pr,R}
//jtd{x<683:R,a>1267:R,x>716:R,A}
//cfp{a>1662:bjn,m>2877:fhq,x<3511:hkz,lnf}
//fgh{a<868:A,A}
//fj{s>498:A,x>470:R,s<310:A,A}
//jqc{x>351:sls,x>175:vgf,x<78:xg,dr}
//znr{x<3162:A,xl}
//md{a>2120:pm,vdf}
//hns{x<1323:A,a<459:R,prj}
//vmt{a<2111:R,a>2159:R,x>3599:R,R}
//tkk{m>1462:A,R}
//jss{a>683:A,m<2406:A,s>498:R,A}
//fb{a<3289:R,s>2460:R,s<1496:rpk,R}
//tm{x>223:R,m<3075:A,R}
//pmn{x>191:A,m<3098:A,x>111:vt,A}
//cz{a<2649:A,x<764:A,R}
//vtb{s>444:A,s<391:R,A}
//jb{a>1498:R,a>1420:A,m<3224:R,A}
//hh{a>280:klc,a>108:R,A}
//vq{m<2056:R,a<1210:A,A}
//tmt{a>3804:R,m>2629:R,s>3327:bjd,A}
//fvn{s>186:bkr,qpr}
//krv{s>2385:A,a<2578:R,R}
//tj{m>2598:A,a>1193:R,R}
//rg{m>554:R,m>240:R,A}
//gkr{a<1028:A,x>437:A,A}
//dcr{s<1303:R,A}
//qg{s<2489:R,A}
//dsh{a>3633:R,a>3507:A,A}
//hjb{x>854:R,m>1887:R,s<3244:A,A}
//fgb{s<768:glp,s>1396:ppx,xz}
//qm{a<505:R,s<2904:A,a>547:R,R}
//zhl{x>2825:A,m<510:R,a>2370:A,R}
//pkh{s>164:R,R}
//zxr{m>2980:A,m<2494:gfc,pnl}
//ttf{x>2552:R,R}
//mcm{m>3429:R,R}
//jbj{a>1917:A,R}
//ss{a<1217:A,R}
//zfm{m<1550:R,a>576:R,R}
//mg{m<3058:A,R}
//zr{a<1925:sv,vtm}
//rjc{a>2606:R,s>584:gt,m<1044:A,lz}
//vk{m<3006:sn,srl}
//tt{s>3218:zts,R}
//lnf{m>2546:lqd,a>1530:R,x<3726:A,grm}
//tcv{x>2714:R,m<1245:R,m>1589:A,R}
//tv{s>2968:A,s>2227:nzb,s>1962:R,R}
//zg{m<3262:A,A}
//srf{m>1444:R,R}
//bhj{m>1827:djd,xn}
//ctk{x<2502:R,m>644:A,A}
//fdj{x>82:R,a>2339:A,a<1175:R,rfr}
//pll{s<1161:ls,R}
//xs{m<3011:R,R}
//rh{a>3077:qbp,lh}
//sz{x<3112:R,A}
//tqv{x<639:sxl,a<1128:bl,a>1226:jtd,tj}
//knh{a>2375:A,A}
//jrk{s>960:A,m>1411:A,m<810:R,A}
//lr{x<385:R,s>1208:R,a<1017:R,R}
//slf{s<653:R,bnd}
//ctz{x<561:R,R}
//hkn{s>2693:R,s<2603:R,R}
//lxg{a<1912:psc,mb}
//kh{x>1524:vr,x>1443:hzx,hl}
//cd{x>2531:tv,x<2337:lzx,m<2086:tt,db}
//vg{a<2179:tl,m>2508:jp,rnl}
//qt{a<1132:R,m>2638:R,x<1495:R,R}
//kcl{s<439:zqp,x<443:pmn,m<3350:ntq,zv}
//xgb{a<3664:jv,x>3124:qn,lqg}
//bpt{s>2526:pl,m<1293:ntn,kvv}
//tqp{a<2756:A,m<3315:A,A}
//pht{m>1841:bt,srv}
//qs{m>1561:A,R}
//kc{s<756:R,s>761:R,a>855:R,A}
//kks{x<663:dg,x<775:sdm,glh}
//bjn{a>1941:vmt,m<3140:A,A}
//vgf{a<571:R,s>464:mg,x>262:rlc,tbz}
//krh{a<1475:R,s>2407:qs,R}
//dc{a>3658:R,A}
//nbg{s>739:A,A}
//ks{m<1544:A,s<3037:A,A}
//cdv{s<2079:xx,a<1586:A,x>541:nnd,zlc}
//sls{m<3378:A,m>3587:vtb,m>3468:A,R}
//gl{m>1579:cn,m>824:R,x<2504:A,zhl}
//gvj{s>3622:A,R}
//xkv{m<830:A,rtp}
//rft{x>2825:nqj,s>873:A,R}
//gh{x<1450:R,x<1708:A,a>1309:A,A}
//nxf{s<512:A,A}
//npj{x<769:R,A}
//lb{a<3931:A,m>2440:A,A}
//dnm{x<2845:hkl,a>1857:hz,ff}
//djz{s<165:R,a>1810:R,m<838:R,A}
//rhs{s>1290:R,s<1113:A,lr}
//jnf{x>260:vm,m>896:A,ncf}
//kvv{s>2083:kcp,a>1714:dtp,R}
//qlf{m>691:llb,fk}
//jnl{s<625:lcb,a<1260:nlg,dnm}
//cld{x>616:gc,x<481:llz,s>2797:kmr,zrt}
//vt{a>3526:R,m<3679:R,A}
//df{m<2933:R,m>3533:R,R}
//gc{m>240:R,s<2813:R,s<2876:R,R}
//rb{m<1705:gf,xqx}
//fn{s<1540:srf,s<1638:R,a>720:R,A}
//xps{a<1670:A,A}
//kj{m<2405:R,a>3278:A,m>3079:A,A}
//zkl{a>2556:A,R}
//km{x<723:R,x<811:A,s>533:R,R}
//jv{m<2128:znr,x<3038:fb,x>3452:nx,lt}
//pb{m<2371:vrv,a<849:zqh,a<1050:jz,ss}
//dr{a>539:R,tmz}
//qd{s>1717:rs,x>3039:pxd,x>2517:jnl,tbx}
//kcp{m<1832:A,x>3478:A,a>1875:A,A}
//cn{m<3187:R,A}
//xn{x<2498:nfs,x>2510:tdn,a>1755:bhl,ctk}
//jq{m>1864:dnk,R}
//fln{x>2453:R,A}
//bls{a<903:vhs,a>1163:R,s>1324:qjb,vzd}
//xg{s>428:R,A}
//pqx{s<951:vp,fgh}
//zlc{x>424:A,s>2117:R,R}
//fk{x>717:qkz,A}
//hkz{s<2594:sz,a<1529:A,s>3242:qgk,A}
//zz{m>2457:R,m<1062:R,R}
//jxg{a<3858:R,m>1156:R,a<3945:R,A}
//sj{a<2577:R,x<214:A,m>658:A,R}
//nqj{x>2968:A,x>2918:A,s<879:A,A}
//zjm{a>1201:A,a>673:R,m>2117:A,R}
//vd{x>2421:A,R}
//pl{a>1664:smh,a<1487:A,m>1282:qln,rrn}
//flb{m<2504:R,A}
//njz{x>2495:R,s>2145:tgm,A}
//lh{a>2770:R,x>1154:A,A}
//tk{s>451:R,R}
//nhf{a>526:R,s>758:A,m<2708:R,R}
//nlg{s>1325:fn,s>969:sjv,s>764:rft,dlv}
//mhk{s<3388:A,s<3786:A,R}
//zxc{s>2700:A,a<929:A,m>2896:A,R}
//tjq{m>467:A,a>884:A,A}
//jf{m>3042:R,x>742:A,x>674:R,R}
//hfj{m>883:R,x<1624:A,s>544:R,R}
//st{x<218:A,a>1185:R,m>424:A,A}
//dgr{x>689:A,R}
//vrv{m>1132:A,m<471:A,x<2426:A,A}
//tjx{s>1411:R,xv}
//dtd{s<1726:rqj,R}
//tb{m<2099:A,s>391:A,a<1891:R,R}
//pvz{x>116:R,R}
//jfh{s>2621:mth,x>463:ktg,R}
//tpq{m<3404:R,s<338:A,A}
//mvc{s<554:A,R}
//vpx{s<3376:R,m>1797:gvj,xqt}
//pxd{a>1203:jdb,x<3509:fgb,kt}
//xv{s>1206:R,a>273:A,a<178:A,A}
//vtm{m>740:hc,tff}
//qsf{s<2344:R,R}
//glp{x>3319:tbp,a>404:jss,A}
//ct{a<3801:tq,vcd}
//kz{x>2544:R,x>2412:A,R}
//rcv{x>322:rg,a<1629:tjq,m<481:ll,sj}
//hx{m<841:bkf,rjc}
//sn{x>74:mj,m<2277:zjm,R}
//qbp{s<334:A,R}
//gk{m>1426:nrx,s>462:hx,x<410:zr,qlf}
//ls{s>887:A,m>1764:A,a<1743:R,A}
//qz{a<3051:qjd,a<3419:R,x>525:R,qsf}
//td{a<930:R,A}
//tbz{x>225:A,s>420:R,a<636:A,A}
//sg{m<764:A,R}
//nzm{m<2663:R,a>2601:A,x<1713:R,A}
//bt{s<428:A,s<619:R,R}
//mdr{m>1924:vz,a>3834:A,jtn}
//qjb{a<1039:A,x<2438:A,R}
//gmf{x<3151:gl,m>1546:vcg,dtm}
//jbd{x>622:jf,x<470:dcf,x>563:zxc,A}
//mzx{a>569:A,x<2860:R,m>3636:R,A}
//jlx{a>1059:A,s>391:tcv,m>1270:R,sg}
//xt{x>1629:R,x<1615:A,R}
//bf{x>2021:A,m<2308:R,x>1936:R,R}
//xhj{m<2273:A,R}
//gsh{a<934:krd,m<3494:R,s<173:qvb,R}
//ldg{x<59:ks,zqq}
//qkz{a>2128:R,A}
//gf{s<2815:xgs,a>1355:lc,hqd}
//rtp{m<1763:A,R}
//sk{m>2350:R,s<472:gh,m<1250:A,A}
//bs{m>2556:A,R}
//sjv{a>608:R,a>295:R,A}
//mpp{x>306:mdb,m<2999:pvz,kjt}
//gvz{a<2936:nm,a<2997:A,kz}
//cm{x<522:R,A}
//qvb{a>1114:A,A}
//msj{a>2017:R,jbj}
//vj{m>2493:kph,R}
//khk{a>2015:jjq,s>2578:jl,lk}
//gfc{x>329:R,x>180:A,R}
//nxv{a<1256:R,scf}
//tvr{m<1620:hr,zgh}
//spf{x>431:np,x>159:rcv,fdj}
//tgm{a<3808:A,A}
//vv{s>470:A,x>1559:R,R}
//bhl{m>1174:R,A}
//cvp{a<2732:dtd,xb}
//vm{x<307:R,m<674:A,A}
//rxz{a<3704:A,R}
//vhs{m>1903:A,R}
//dg{a>1981:vpx,m<2484:td,x>492:bnm,sfz}
//grm{m<2343:A,m<2453:A,m>2515:A,R}
//bkf{m>381:A,A}
//lqg{a>3849:hb,a>3763:njz,s<1979:nc,ksd}
//lv{x>873:vh,s>1928:qdv,s<801:zc,tvr}
//bjd{m>1439:R,x>3274:A,x<3190:A,A}
//htv{s>632:lpq,x>3727:R,jgb}
//gz{m<2910:A,m<3037:R,m>3112:R,R}
//gcb{s<3266:R,A}
//pnl{m>2775:R,R}
//zgh{a>1712:ltc,x>460:rfj,xh}
//rfj{a>1129:dgr,s<1540:fx,cpn}
//gt{s<664:R,x<345:A,R}
//db{a>805:R,a>320:R,zb}
//pnq{m>3118:A,x>3840:A,R}
//nk{s<2788:R,s>3293:A,s>3099:A,A}
//sp{x<3298:A,x<3443:fc,hkg}
//sxl{a>1200:R,R}
//in{x<2169:lv,jtq}
//vzd{a>1040:A,m<2381:R,R}
//rfr{s<1334:A,R}
//jz{s<553:R,s>856:A,R}
//rc{x>1788:qg,a>2368:bvz,ghz}
//ntn{a>1757:mm,x>3454:A,x>3057:R,R}
//gfs{m>2699:A,x<2480:A,A}
//sfz{x<413:A,A}
//ppx{s<1560:A,m<2567:A,A}
//hd{s>3328:R,A}
//vbz{a<393:A,x<579:A,A}
//xlq{x>3739:A,a<1661:A,a>1986:R,A}
//mb{s>1140:R,s>456:vd,A}
//ln{m>1006:A,a<751:A,x>233:R,R}
//xqx{m>2806:R,s>3013:nl,a>2566:bf,xhj}
//hs{a<590:A,x>168:tm,R}
//dtp{x>3326:A,R}
//xz{s>1071:R,A}
//mrs{a>1325:kmq,m>2878:zgq,x>535:jr,fh}
//hnr{m<258:R,A}
//bsn{m<3351:R,s>367:mzx,R}
//kdv{m<3518:R,s<345:R,R}
//cl{m<2974:R,m>3549:R,A}
//bz{x<326:A,m<2795:ctz,gs}
//ggh{m<3295:A,m<3732:A,a>1469:A,R}
//qrd{x>685:A,a<3241:A,R}
//bh{s>1744:mv,s>958:R,m>2522:R,R}
//htj{a<1667:A,a>2011:R,A}
//nc{s>792:A,s>359:mvc,pvd}
//lqd{a<1471:R,R}
//hl{x<1415:A,R}
//lpq{m>3378:R,A}
//rqj{x<3502:A,x<3795:R,A}
//xd{s<704:slf,m>3238:nbg,vrk}
//xqt{s>3768:A,A}
//zsj{m<2483:R,a<3821:R,a<3848:A,A}
//cpn{s<1781:tjs,stg}
//mm{a<2038:A,m<728:A,s>2014:A,A}
//smh{x>3274:R,m>1059:A,m<388:A,R}
//psz{a<2572:A,x<639:gv,x>758:R,A}
//fc{x>3351:R,A}

//{x=1297,m=847,a=1986,s=23}
//{x=2427,m=1330,a=870,s=806}
//{x=2340,m=191,a=2050,s=2684}
//{x=17,m=1571,a=66,s=1289}
//{x=2092,m=1022,a=2623,s=1380}
//{x=49,m=2019,a=2261,s=747}
//{x=426,m=563,a=1998,s=190}
//{x=1369,m=141,a=55,s=262}
//{x=246,m=847,a=320,s=24}
//{x=139,m=393,a=329,s=2645}
//{x=667,m=808,a=1425,s=228}
//{x=632,m=356,a=198,s=654}
//{x=1023,m=1018,a=794,s=1182}
//{x=295,m=1097,a=278,s=262}
//{x=74,m=197,a=310,s=1341}
//{x=194,m=511,a=1673,s=1352}
//{x=315,m=368,a=617,s=948}
//{x=1940,m=2114,a=2797,s=125}
//{x=1859,m=962,a=1707,s=753}
//{x=2654,m=507,a=1585,s=1491}
//{x=1446,m=380,a=53,s=132}
//{x=1194,m=30,a=226,s=160}
//{x=730,m=853,a=668,s=1317}
//{x=1720,m=4,a=693,s=789}
//{x=3128,m=2049,a=901,s=386}
//{x=432,m=1944,a=1642,s=809}
//{x=1611,m=1523,a=619,s=1840}
//{x=706,m=1351,a=222,s=689}
//{x=1325,m=28,a=98,s=843}
//{x=87,m=1339,a=802,s=461}
//{x=223,m=117,a=443,s=1362}
//{x=107,m=738,a=1071,s=155}
//{x=2271,m=1414,a=1917,s=1101}
//{x=1578,m=24,a=2823,s=263}
//{x=1026,m=1498,a=203,s=455}
//{x=1010,m=1184,a=677,s=2707}
//{x=995,m=2094,a=1431,s=1680}
//{x=973,m=1402,a=268,s=626}
//{x=3395,m=343,a=895,s=1497}
//{x=1431,m=358,a=2569,s=25}
//{x=1875,m=14,a=1442,s=1563}
//{x=718,m=48,a=1008,s=2042}
//{x=1459,m=66,a=2819,s=1400}
//{x=1754,m=978,a=3085,s=33}
//{x=257,m=907,a=917,s=224}
//{x=2365,m=55,a=798,s=540}
//{x=563,m=68,a=155,s=10}
//{x=683,m=1353,a=488,s=951}
//{x=2453,m=1123,a=2716,s=2187}
//{x=2784,m=1562,a=176,s=3}
//{x=91,m=942,a=1419,s=1535}
//{x=244,m=2537,a=2996,s=1742}
//{x=739,m=282,a=2264,s=1042}
//{x=3147,m=654,a=1287,s=207}
//{x=1997,m=288,a=150,s=256}
//{x=2867,m=564,a=212,s=146}
//{x=470,m=577,a=115,s=211}
//{x=958,m=333,a=1709,s=195}
//{x=1023,m=818,a=197,s=1957}
//{x=2240,m=103,a=143,s=3441}
//{x=288,m=2255,a=443,s=1974}
//{x=405,m=810,a=340,s=569}
//{x=29,m=114,a=2403,s=803}
//{x=1634,m=761,a=1284,s=320}
//{x=147,m=1138,a=454,s=71}
//{x=91,m=613,a=1464,s=1089}
//{x=567,m=2599,a=7,s=724}
//{x=151,m=789,a=2257,s=75}
//{x=623,m=1217,a=378,s=161}
//{x=1852,m=1420,a=1364,s=27}
//{x=82,m=1218,a=789,s=971}
//{x=1890,m=1878,a=808,s=1929}
//{x=37,m=1434,a=137,s=682}
//{x=1365,m=1531,a=1578,s=1923}
//{x=974,m=1114,a=2077,s=695}
//{x=2344,m=264,a=468,s=63}
//{x=7,m=326,a=2379,s=557}
//{x=965,m=2139,a=128,s=227}
//{x=1997,m=1044,a=2475,s=1937}
//{x=1118,m=2867,a=1438,s=621}
//{x=823,m=333,a=1507,s=1818}
//{x=241,m=1179,a=973,s=196}
//{x=116,m=980,a=290,s=3241}
//{x=1320,m=1449,a=42,s=219}
//{x=2294,m=3370,a=163,s=1778}
//{x=113,m=856,a=203,s=1738}
//{x=767,m=1025,a=885,s=1692}
//{x=370,m=873,a=2051,s=495}
//{x=72,m=1539,a=302,s=2028}
//{x=1394,m=1325,a=781,s=1442}
//{x=287,m=140,a=16,s=1057}
//{x=6,m=546,a=721,s=1537}
//{x=456,m=58,a=1348,s=1149}
//{x=1164,m=1658,a=682,s=550}
//{x=43,m=3381,a=1105,s=1293}
//{x=1087,m=156,a=2184,s=724}
//{x=224,m=132,a=1507,s=1902}
//{x=1822,m=3486,a=3078,s=625}
//{x=608,m=1103,a=1504,s=461}
//{x=2395,m=170,a=386,s=312}
//{x=2092,m=878,a=452,s=1254}
//{x=307,m=153,a=771,s=375}
//{x=1246,m=200,a=593,s=1543}
//{x=839,m=87,a=117,s=286}
//{x=442,m=887,a=2636,s=214}
//{x=50,m=119,a=703,s=2342}
//{x=1816,m=676,a=1617,s=2325}
//{x=125,m=678,a=570,s=919}
//{x=73,m=1075,a=880,s=223}
//{x=199,m=317,a=266,s=3}
//{x=2750,m=960,a=616,s=338}
//{x=2295,m=2885,a=891,s=593}
//{x=2311,m=1,a=107,s=2274}
//{x=1438,m=653,a=204,s=2947}
//{x=478,m=710,a=602,s=683}
//{x=90,m=1541,a=2,s=1314}
//{x=298,m=1293,a=695,s=49}
//{x=210,m=93,a=1782,s=82}
//{x=235,m=1586,a=3025,s=3541}
//{x=161,m=374,a=795,s=533}
//{x=1636,m=1,a=240,s=44}
//{x=749,m=199,a=862,s=384}
//{x=315,m=357,a=335,s=1365}
//{x=204,m=494,a=2778,s=2157}
//{x=1947,m=2591,a=735,s=1026}
//{x=1887,m=1603,a=57,s=337}
//{x=2031,m=363,a=196,s=433}
//{x=228,m=1266,a=857,s=606}
//{x=1368,m=1459,a=638,s=588}
//{x=425,m=154,a=222,s=3212}
//{x=1709,m=436,a=162,s=1561}
//{x=913,m=728,a=1895,s=679}
//{x=1833,m=1748,a=2700,s=15}
//{x=904,m=807,a=2200,s=460}
//{x=305,m=720,a=82,s=15}
//{x=166,m=90,a=1269,s=2425}
//{x=1420,m=1363,a=280,s=1863}
//{x=697,m=692,a=54,s=948}
//{x=2016,m=17,a=1656,s=334}
//{x=532,m=2434,a=272,s=227}
//{x=1613,m=43,a=423,s=475}
//{x=2657,m=1,a=1897,s=1870}
//{x=272,m=277,a=253,s=1331}
//{x=2206,m=3298,a=110,s=1127}
//{x=626,m=787,a=758,s=546}
//{x=1615,m=646,a=182,s=2154}
//{x=1487,m=1679,a=6,s=439}
//{x=3310,m=1653,a=2458,s=18}
//{x=870,m=1586,a=278,s=60}
//{x=2462,m=68,a=827,s=38}
//{x=380,m=121,a=282,s=551}
//{x=174,m=172,a=997,s=37}
//{x=392,m=600,a=88,s=210}
//{x=299,m=128,a=28,s=56}
//{x=1969,m=2488,a=686,s=1196}
//{x=63,m=965,a=1133,s=1045}
//{x=274,m=852,a=1282,s=2743}
//{x=552,m=552,a=1032,s=352}
//{x=349,m=2778,a=946,s=1920}
//{x=1524,m=1971,a=1681,s=1921}
//{x=934,m=2170,a=158,s=3}
//{x=59,m=1250,a=2130,s=1508}
//{x=2292,m=103,a=46,s=1527}
//{x=1718,m=410,a=201,s=681}
//{x=1289,m=854,a=916,s=788}
//{x=123,m=507,a=3852,s=1268}
//{x=2642,m=86,a=153,s=1756}
//{x=748,m=210,a=595,s=999}
//{x=692,m=727,a=1491,s=494}
//{x=402,m=2054,a=315,s=124}
//{x=155,m=2053,a=1257,s=85}
//{x=766,m=440,a=1032,s=365}
//{x=135,m=459,a=781,s=139}
//{x=76,m=2100,a=288,s=219}
//{x=428,m=2622,a=1390,s=26}
//{x=33,m=3436,a=588,s=345}
//{x=35,m=95,a=380,s=66}
//{x=16,m=531,a=1602,s=394}
//{x=626,m=380,a=1215,s=1156}
//{x=1946,m=251,a=418,s=1080}
//{x=1406,m=1040,a=1384,s=505}
//{x=780,m=81,a=207,s=2360}
//{x=243,m=556,a=385,s=820}
//{x=92,m=2687,a=1087,s=1255}
//{x=58,m=109,a=1568,s=189}
//{x=130,m=1221,a=114,s=1084}
//{x=645,m=265,a=261,s=1646}
//{x=324,m=149,a=490,s=700}
//{x=1411,m=1114,a=22,s=446}
//{x=1723,m=2242,a=997,s=1744}
//{x=78,m=906,a=711,s=397}
//{x=260,m=966,a=409,s=2697}
//{x=943,m=886,a=1265,s=150}
//{x=2622,m=143,a=1546,s=410}
//{x=410,m=197,a=318,s=556}
//{x=162,m=2729,a=3063,s=13}
//{x=419,m=1669,a=1359,s=539}
//{x=382,m=1948,a=1164,s=400}
//{x=98,m=59,a=163,s=475}
//{x=3316,m=1132,a=409,s=527}";

//var smallInput =
//@"px{a<2006:qkq,m>2090:A,rfg}
//pv{a>1716:R,A}
//lnx{m>1548:A,A}
//rfg{s<537:gd,x>2440:R,A}
//qs{s>3448:A,lnx}
//qkq{x<1416:A,crn}
//crn{x>2662:A,R}
//in{s<1351:px,qqz}
//qqz{s>2770:qs,m<1801:hdj,R}
//gd{a>3333:R,R}
//hdj{m>838:A,pv}

//{x=787,m=2655,a=1222,s=2876}
//{x=1679,m=44,a=2067,s=496}
//{x=2036,m=264,a=79,s=2244}
//{x=2461,m=1339,a=466,s=291}
//{x=2127,m=1623,a=2188,s=1013}";

//var smallest = "in{s<1351:px,qqz}";

//var input = smallInput;
//input = fullInput;
////input = smallest;
//var timer = System.Diagnostics.Stopwatch.StartNew();
//var result = BigInteger.Zero;
//var workflows = input.Split(Environment.NewLine).TakeWhile(x => x != "").Select(ParseWorkflow).ToDictionary(x => x.Name, x => x);


//var fullRange = new FullRange { Ranges = new[] { 'x', 'm', 'a', 's' }.ToDictionary(x => x, x => new Range { From = 1, To = 4000 }) };

//var acceptedRanges = new List<FullRange>();
//AnalyzeWorkflow(workflows["in"], fullRange);
//result = acceptedRanges.Select(Product).Aggregate(BigInteger.Add);

//BigInteger Product(FullRange range) => range.Ranges.Select(x => x.Value.To - x.Value.From + 1).Select(x => new BigInteger(x)).Aggregate(BigInteger.Multiply);

//FullRange KeepOnly(FullRange x, int value, bool greaterThan, char letter)
//{
//    var fullRange = x.Copy();

//    fullRange.Ranges[letter] = Keep(x.Ranges[letter], value, greaterThan);

//    return fullRange;
//}

//Range Keep(Range range, int value, bool greaterThan)
//{
//    if (greaterThan)
//    {
//        if (range.From >= value)
//        {
//            return range;
//        }
//        else if (range.To < value)
//        {
//            return null;
//        }
//        else
//        {
//            return new Range { From = value, To = range.To };
//        }
//    }
//    else
//    {
//        if (value < range.From)
//        {
//            return null;
//        }
//        else if (range.To <= value)
//        {
//            return range;
//        }
//        else
//        {
//            return new Range { From = range.From, To = value };
//        }
//    }
//}

//void AnalyzeWorkflow(Workflow xx, FullRange fullRange)
//{
//    var workflow = xx.Copy();
//    var operation = workflow.Operations.First();

//    if (operation is WorkflowPointer p)
//    {
//        AnalyzeWorkflow(workflows[p.NextOperationName], fullRange);
//        return;
//    }

//    if (operation is AcceptedOperation)
//    {
//        acceptedRanges.Add(fullRange);
//        return;
//    }
//    if (operation is RejectedOperation)
//    {
//        return;
//    }

//    Workflow GetNext()
//    {
//        if (operation.NextOperationName == "R") { return new Workflow { Operations = new List<Operation> { new RejectedOperation() } }; }
//        if (operation.NextOperationName == "A") { return new Workflow { Operations = new List<Operation> { new AcceptedOperation() } }; }
//        return workflows[operation.NextOperationName];

//    }
//    var p1 = KeepOnly(fullRange, operation.Value + (!operation.IsGreaterThan ? -1 : 1), operation.IsGreaterThan, operation.Param);
//    var p2 = KeepOnly(fullRange, operation.Value, !operation.IsGreaterThan, operation.Param);

//    AnalyzeWorkflow(GetNext(), p1);
//    workflow.Operations.RemoveAt(0);
//    AnalyzeWorkflow(workflow, p2);
//}

//timer.Stop();
//Console.WriteLine(result);
//Console.WriteLine(timer.ElapsedMilliseconds + "ms"); // 124147505282199 too low
//Console.ReadLine();

//Workflow ParseWorkflow(string str)
//{
//    var split = str.Replace("}", "").Split("{");
//    var name = split[0];
//    var operations = split[1].Split(",").Select(ParseOperation).ToList();
//    return new Workflow { Name = name, Operations = operations };
//}

//Operation ParseOperation(string str)
//{
//    if (!str.Contains(":"))
//    {
//        switch (str)
//        {
//            case "A": return new AcceptedOperation();
//            case "R": return new RejectedOperation();
//            default: return new WorkflowPointer { NextOperationName = str };
//        }
//    }
//    var split = str.Split('<', '>', ':');
//    return new Operation { Param = split[0][0], IsGreaterThan = str.Contains(">"), Value = int.Parse(split[1]), NextOperationName = split[2] };
//}

//class Operation
//{
//    public char Param { get; set; }
//    public bool IsGreaterThan { get; set; }
//    public int Value { get; set; }
//    public string NextOperationName { get; set; }
//    public override string ToString() => $"{Param}{(IsGreaterThan ? ">" : "<")}{Value}:{NextOperationName}";

//}

//class AcceptedOperation : Operation
//{
//}

//class RejectedOperation : Operation
//{
//}
//class WorkflowPointer : Operation
//{
//}

//class Workflow
//{
//    public string Name { get; set; }
//    public List<Operation> Operations { get; set; }
//    public Workflow Copy() => new Workflow { Name = Name, Operations = Operations.ToList() };

//}

//class FullRange
//{
//    public Dictionary<char, Range> Ranges { get; set; }
//    public FullRange Copy() => new FullRange { Ranges = Ranges.ToDictionary(x => x.Key, x => x.Value) };

//}

//class Range
//{
//    public int From { get; set; }
//    public int To { get; set; }

//}