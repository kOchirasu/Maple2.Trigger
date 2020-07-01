using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000328_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 7001, arg2: false, arg3: false);
                context.SetLadder(arg1: 7002, arg2: false, arg3: false);
                context.SetLadder(arg1: 7003, arg2: false, arg3: false);
                context.SetLadder(arg1: 7004, arg2: false, arg3: false);
                context.SetLadder(arg1: 7005, arg2: false, arg3: false);
                context.SetLadder(arg1: 7006, arg2: false, arg3: false);
                context.SetLadder(arg1: 7007, arg2: false, arg3: false);
                context.SetLadder(arg1: 7008, arg2: false, arg3: false);
                context.SetLadder(arg1: 7009, arg2: false, arg3: false);
                context.SetLadder(arg1: 7010, arg2: false, arg3: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138,
                        139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157,
                        158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238,
                        239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257,
                        258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338,
                        339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357,
                        358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419,
                        420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619,
                        620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638,
                        639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650, 651, 652, 653, 654, 655, 656
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719,
                        720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737, 738,
                        739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755, 756
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819,
                        820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838,
                        839, 840, 841, 842, 843, 844, 845, 846, 847, 848, 849, 850, 851, 852, 853, 854, 855, 856, 857
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919,
                        920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931, 932, 933, 934, 935, 936, 937, 938,
                        939, 940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                        2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032,
                        2033, 2034, 2035, 2036, 2037, 2038, 2039, 2040, 2041, 2042, 2043, 2044, 2045, 2046, 2047, 2048,
                        2049, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2059, 2060, 2061, 2062, 2063, 2064,
                        2065, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078, 2079, 2080,
                        2081, 2082, 2083, 2084, 2085, 2086, 2087, 2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095, 2096,
                        2097, 2098, 2099, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112,
                        2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128,
                        2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144,
                        2145, 2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160,
                        2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176,
                        2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192,
                        2193, 2194, 2195, 2196, 2197, 2198, 2199, 2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208,
                        2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224,
                        2225, 2226, 2227, 2228, 2229, 2230, 2231, 2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240,
                        2241, 2242, 2243, 2244, 2245, 2246, 2247, 2248, 2249, 2250, 2251, 2252, 2253, 2254, 2255, 2256,
                        2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268, 2269, 2270, 2271
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316,
                        2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332,
                        2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {90000}, arg2: true);
                context.SetEffect(arg1: new[] {84000}, arg2: false);
                context.SetEffect(arg1: new[] {84001}, arg2: false);
                context.SetEffect(arg1: new[] {84002}, arg2: false);
                context.CreateMonster(arg1: new[] {10002, 10006, 10015}, arg2: false);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105}, arg2: false);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205}, arg2: false);
                context.CreateMonster(arg1: new[] {1301, 1302, 1303, 1304, 1305}, arg2: false);
                context.CreateMonster(arg1: new[] {1401, 1402, 1403, 1404, 1405}, arg2: false);
                context.SetCube(ids: new[] {5001, 5002, 5003, 5004}, isVisible: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State하층시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하층시작 : TriggerState {
            internal State하층시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {999998}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20003285, textId: 20003285, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 60000, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017
                    }, arg2: false, arg3: 500, arg4: 100, arg5: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라줌인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라줌인 : TriggerState {
            internal State카메라줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 60001, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20003286, textId: 20003286, duration: 5000);
                    context.RemoveBuff(arg1: 999998, arg2: 70000107);
                    context.CameraSelect(arg1: 60001, arg2: false);
                    context.State = new State웨폰오브젝트대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨폰오브젝트대기 : TriggerState {
            internal State웨폰오브젝트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5001, 5002, 5003, 5004}, isVisible: true);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999997})) {
                    context.SetEffect(arg1: new[] {84002}, arg2: true);
                    context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000328_BF__MAIN__6$", arg4: 5, arg5: 0);
                    context.State = new State하층클리어대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하층클리어대기 : TriggerState {
            internal State하층클리어대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003286, textId: 20003286, duration: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {
                    10000, 10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013,
                    10014, 10015
                })) {
                    context.State = new State상층시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상층시작딜레이 : TriggerState {
            internal State상층시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State상층시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State상층시작 : TriggerState {
            internal State상층시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 7001, arg2: true, arg3: true);
                context.SetLadder(arg1: 7002, arg2: true, arg3: true);
                context.SetLadder(arg1: 7003, arg2: true, arg3: true);
                context.SetLadder(arg1: 7004, arg2: true, arg3: true);
                context.SetLadder(arg1: 7005, arg2: true, arg3: true);
                context.SetLadder(arg1: 7006, arg2: true, arg3: true);
                context.SetLadder(arg1: 7007, arg2: true, arg3: true);
                context.SetLadder(arg1: 7008, arg2: true, arg3: true);
                context.SetLadder(arg1: 7009, arg2: true, arg3: true);
                context.SetLadder(arg1: 7010, arg2: true, arg3: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003282, textId: 20003282);
                context.CameraSelect(arg1: 60002, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.CameraSelect(arg1: 60002, arg2: false);
                    context.State = new State보스소환조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환조건 : TriggerState {
            internal State보스소환조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {
                    1101, 1102, 1103, 1104, 1201, 1202, 1203, 1204, 1205, 1301, 1302, 1303, 1304, 1401, 1402, 1403,
                    1404, 1405, 1105, 1305
                })) {
                    context.State = new State보스소환딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환딜레이 : TriggerState {
            internal State보스소환딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스소환 : TriggerState {
            internal State보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003282);
                context.ShowGuideSummary(entityId: 20003283, textId: 20003283, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.AddBuff(arg1: new[] {999998}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 60003, arg2: true);
                context.CreateMonster(arg1: new[] {1501}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State진행3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 999998, arg2: 70000107);
                context.CameraSelect(arg1: 60003, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1501})) {
                    context.State = new State진행4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행4 : TriggerState {
            internal State진행4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State진행5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행5 : TriggerState {
            internal State진행5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999996, key: "clearafter", value: 1);
                context.CreateMonster(arg1: new[] {2000}, arg2: false);
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData0");
                context.SetConversation(arg1: 1, arg2: 2000, arg3: "$02000328_BF__MAIN__5$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State진행6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행6 : TriggerState {
            internal State진행6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 60002, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2000, arg3: "$02000328_BF__MAIN__4$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State진행7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행7 : TriggerState {
            internal State진행7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {90000}, arg2: false);
                context.SetEffect(arg1: new[] {84000}, arg2: true);
                context.SetEffect(arg1: new[] {84001}, arg2: true);
                context.SetMesh(arg1: new[] {413, 414, 419, 420}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {406, 407, 408, 409, 412, 415, 418, 421, 424, 425, 426, 427},
                    arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {401, 402, 403, 404, 405, 410, 411, 416, 417, 422, 423, 428, 429, 430, 431, 432},
                    arg2: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312},
                    arg2: false, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323},
                    arg2: false, arg3: 400, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334},
                    arg2: false, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343}, arg2: false,
                    arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {601, 602, 603, 604, 605, 606, 607}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {608, 609, 610, 611, 612, 613}, arg2: true, arg3: 400, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {614, 615, 616, 617, 618, 619, 620}, arg2: true, arg3: 500, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {621, 622, 623, 624, 625, 626, 627, 628, 629, 630}, arg2: true,
                    arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {631, 632, 633, 634, 635}, arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {701, 702, 703, 704, 705, 706, 707}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {708, 709, 710, 711, 712, 713}, arg2: true, arg3: 400, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {714, 715, 716, 717, 718, 719, 720}, arg2: true, arg3: 500, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {721, 722, 723, 724, 725, 726, 727, 728, 729, 730}, arg2: true,
                    arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {726}, arg2: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {731, 732, 733, 734}, arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {801, 802, 803, 804, 805, 806, 807}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {808, 809, 810, 811, 812, 813}, arg2: true, arg3: 400, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {814, 815, 816, 817, 818, 819, 820}, arg2: true, arg3: 500, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {821, 822, 823, 824, 825, 826, 827, 828, 829, 830}, arg2: true,
                    arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {831, 832, 833, 834, 835, 836}, arg2: true, arg3: 700, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {901, 902, 903, 904, 905, 906, 907}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {908, 909, 910, 911, 912, 913}, arg2: true, arg3: 400, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {914, 915, 916, 917, 918, 919, 920}, arg2: true, arg3: 500, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {921, 922, 923, 924, 925, 926, 927, 928, 929, 930}, arg2: true,
                    arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {931, 932, 933, 934, 935, 936}, arg2: true, arg3: 700, arg4: 50,
                    arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650, 651, 652, 653, 654,
                        655, 656
                    }, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753,
                        754, 755
                    }, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847, 848, 849, 850, 851, 852, 853, 854, 855,
                        856, 857
                    }, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        937, 938, 939, 940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955,
                        956, 957
                    }, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                        2017, 2018, 2019, 2020, 2021
                    }, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2037,
                        2038, 2039, 2040, 2041, 2042
                    }, arg2: true, arg3: 1200, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2043, 2044, 2045, 2046, 2047, 2048, 2049, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058,
                        2059, 2060, 2061, 2062, 2063
                    }, arg2: true, arg3: 1400, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2064, 2065, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078, 2079,
                        2080, 2081, 2082, 2083, 2084
                    }, arg2: true, arg3: 1600, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2085, 2086, 2087, 2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095, 2096, 2097, 2098, 2099, 2100,
                        2101, 2102, 2103, 2104, 2105
                    }, arg2: true, arg3: 1800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121,
                        2122, 2123, 2124, 2125, 2126
                    }, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142,
                        2143, 2144, 2145, 2146, 2147
                    }, arg2: true, arg3: 1200, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163,
                        2164, 2165, 2166, 2167, 2168
                    }, arg2: true, arg3: 2400, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184,
                        2185, 2186, 2187, 2188, 2189
                    }, arg2: true, arg3: 2600, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2198, 2199, 2200, 2201, 2202, 2203, 2204, 2205,
                        2206, 2207, 2208, 2209, 2210
                    }, arg2: true, arg3: 2800, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221, 2222, 2223, 2224, 2225, 2226,
                        2227, 2228, 2229, 2230, 2231
                    }, arg2: true, arg3: 3000, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2232, 2233, 2234, 2235, 2236, 2237, 2238, 2239, 2240, 2241, 2242, 2243, 2244, 2245, 2246, 2247,
                        2248, 2249, 2250, 2251, 2252
                    }, arg2: true, arg3: 3200, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new[] {
                        2253, 2254, 2255, 2256, 2257, 2258, 2259, 2260, 2261, 2262, 2263, 2264, 2265, 2266, 2267, 2268,
                        2269, 2270, 2271
                    }, arg2: true, arg3: 3400, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {450}, arg2: false, arg3: 3600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {451}, arg2: false, arg3: 3700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {452}, arg2: false, arg3: 3800, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {453}, arg2: false, arg3: 3900, arg4: 50, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.CameraSelect(arg1: 60002, arg2: false);
                    context.State = new State진행8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행8 : TriggerState {
            internal State진행8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State진행9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행9 : TriggerState {
            internal State진행9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 999998, arg2: "trigger", arg3: "ClearPollutedgarden");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003284, textId: 20003284);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.HideGuideSummary(entityId: 20003284);
                    context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료2 : TriggerState {
            internal State종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}