using System;

namespace Maple2.Trigger._02000545_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
                        2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031,
                        2032, 2033, 2034, 2035, 2036, 2037, 2038, 2039, 2040, 2041, 2042, 2043, 2044, 2045, 2046, 2047,
                        2048, 2049, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2059, 2060, 2061, 2062, 2063,
                        2064, 2065, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078, 2079,
                        2080, 2081, 2082, 2083, 2084, 2085, 2086, 2087, 2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095,
                        2096, 2097, 2098, 2099, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111,
                        2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127,
                        2128, 2129, 2130, 2131, 2132
                    }, arg2: true);
                context.SetMesh(arg1: new int[] {2141, 2142}, arg2: true);
                context.SetMesh(arg1: new int[] {2133, 2134}, arg2: false);
                context.SetMesh(arg1: new int[] {2150, 2151}, arg2: false);
                context.SetMesh(arg1: new int[] {2999}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
                context.SetEffect(arg1: new int[] {5009}, arg2: false);
                context.SetEffect(arg1: new int[] {5010}, arg2: false);
                context.SetEffect(arg1: new int[] {5011}, arg2: false);
                context.SetEffect(arg1: new int[] {5012}, arg2: false);
                context.SetEffect(arg1: new int[] {5013}, arg2: false);
                context.SetEffect(arg1: new int[] {5014}, arg2: false);
                context.SetEffect(arg1: new int[] {5015}, arg2: false);
                context.SetSkill(arg1: new int[] {3000}, arg2: false);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 106, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "703", arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {601, 602, 603, 604, 605, 606, 607}, arg2: false);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000545_BF__MAIN__0$");
                context.AddBalloonTalk(spawnPointID: 604, duration: 3500, delayTick: 1000);
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 603, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 604, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 605, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701", arg2: 0)) {
                    context.State = new State어이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어이 : TriggerState {
            internal State어이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 5000,
                    script: "$02000545_BF__MAIN__1$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State몬스터웨이브안내토끼1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터웨이브안내토끼1 : TriggerState {
            internal State몬스터웨이브안내토끼1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__2$");
                context.AddBalloonTalk(spawnPointID: 602, msg: "$02000545_BF__MAIN__3$", duration: 3500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 603, msg: "$02000545_BF__MAIN__4$", duration: 3500,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 604, msg: "$02000545_BF__MAIN__5$", duration: 3500,
                    delayTick: 2000);
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 603, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 604, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 605, arg2: "Bore_A");
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
                context.SetEffect(arg1: new int[] {5008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State물가보여주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State물가보여주기 : TriggerState {
            internal State물가보여주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(arg1: new int[] {7001}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004687, msg: "$02000545_BF__MAIN__6$", align: "left", duration: 4000);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetSceneSkip(arg1: "몬스터웨이브1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State몬스터웨이브1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터웨이브1 : TriggerState {
            internal State몬스터웨이브1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 2f);
                context.SetEventUI(arg1: 1, arg2: "$02000545_BF__MAIN__7$", arg3: new int[] {3000});
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new int[] {401, 402, 403, 404, 405}, arg2: true);
                context.DestroyMonster(arg1: new int[] {602, 603, 604, 605});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State몬스터웨이브2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터웨이브2 : TriggerState {
            internal State몬스터웨이브2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__8$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {401, 402, 403, 404, 405, 201})) {
                    context.State = new State몬스터웨이브2시작안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터웨이브2시작안내 : TriggerState {
            internal State몬스터웨이브2시작안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__9$");
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State엘리트스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트스폰 : TriggerState {
            internal State엘리트스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000545_BF__MAIN__10$", arg3: new int[] {3000});
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.SetEffect(arg1: new int[] {5009}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엘리트스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트스폰2 : TriggerState {
            internal State엘리트스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000545_BF__MAIN__11$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {202})) {
                    context.State = new State엘리트사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트사망 : TriggerState {
            internal State엘리트사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__12$");
                context.SetEffect(arg1: new int[] {5009}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보스시작전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스시작전 : TriggerState {
            internal State보스시작전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 4000,
                    script: "$02000545_BF__MAIN__13$");
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스시작 : TriggerState {
            internal State보스시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 02000545, arg2: 3);
                context.SetSceneSkip(arg1: "거미여왕기어올라오기", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {7004}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State거미여왕스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕스폰2 : TriggerState {
            internal State거미여왕스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {608}, arg2: true);
                context.AddCinematicTalk(npcID: 11004687, msg: "$02000545_BF__MAIN__14$", align: "left",
                    duration: 3000);
                context.SetMesh(
                    arg1: new int[] {
                        2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2059, 2060, 2061, 2062, 2063, 2064, 2065, 2066,
                        2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078, 2079, 2080, 2081, 2082,
                        2083, 2084, 2085, 2086, 2087, 2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095, 2096, 2097, 2098,
                        2099, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114,
                        2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130,
                        2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146,
                        2147
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State거미여왕스폰3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕스폰3 : TriggerState {
            internal State거미여왕스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
                        2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031,
                        2032, 2033, 2034, 2035, 2036, 2037, 2038, 2039, 2040, 2041, 2042, 2043, 2044, 2045, 2046, 2047,
                        2048, 2049, 2050
                    }, arg2: false);
                context.SetMesh(arg1: new int[] {2141, 2142}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5012}, arg2: true);
                context.SetEffect(arg1: new int[] {5013}, arg2: true);
                context.SetEffect(arg1: new int[] {5014}, arg2: true);
                context.SetEffect(arg1: new int[] {5015}, arg2: true);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcID: 11004687, msg: "$02000545_BF__MAIN__15$", align: "left",
                    duration: 3000);
                context.SetMesh(arg1: new int[] {2999}, arg2: true);
                context.SetEffect(arg1: new int[] {5010}, arg2: true);
                context.DestroyMonster(arg1: new int[] {606, 607});
                context.SetNpcEmotionLoop(arg1: 608, arg2: "Stun_A", arg3: 10000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State거미여왕스폰4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕스폰4 : TriggerState {
            internal State거미여왕스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {608});
                context.SetEffect(arg1: new int[] {5010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State거미여왕기어올라오기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕기어올라오기 : TriggerState {
            internal State거미여왕기어올라오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {7004, 7005}, arg2: 0);
                context.SetEffect(arg1: new int[] {5011}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.AddCinematicTalk(npcID: 23300010, msg: "$02000545_BF__MAIN__16$", align: "left",
                    duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State거미여왕스폰5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕스폰5 : TriggerState {
            internal State거미여왕스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5011}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5012}, arg2: false);
                context.SetEffect(arg1: new int[] {5013}, arg2: false);
                context.SetEffect(arg1: new int[] {5014}, arg2: false);
                context.SetEffect(arg1: new int[] {5015}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State거미여왕스폰6(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State거미여왕스폰6 : TriggerState {
            internal State거미여왕스폰6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__17$");
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 90, spawnPointId: 102, isRelative: "true")) {
                    context.State = new State쫄몬스터소환1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몬스터소환1 : TriggerState {
            internal State쫄몬스터소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23300010, illust: "ArakiaDark_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__18$");
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 70, spawnPointId: 102, isRelative: "true")) {
                    context.State = new State쫄몬스터소환2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몬스터소환2 : TriggerState {
            internal State쫄몬스터소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23300010, illust: "ArakiaDark_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__19$");
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 29, spawnPointId: 102, isRelative: "true")) {
                    context.State = new State쫄몬스터소환3(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쫄몬스터소환3 : TriggerState {
            internal State쫄몬스터소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23300010, illust: "ArakiaDark_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__20$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State던전클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어 : TriggerState {
            internal State던전클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__21$");
                context.DestroyMonster(arg1: new int[] {301, 302, 303, 304, 305, 501, 502, 505, 507});
                context.CreateMonster(arg1: new int[] {602, 603, 604, 605}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 602, msg: "$02000545_BF__MAIN__22$", duration: 3500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 603, msg: "$02000545_BF__MAIN__23$", duration: 3500,
                    delayTick: 800);
                context.AddBalloonTalk(spawnPointID: 604, msg: "$02000545_BF__MAIN__24$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State던전클리어2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어2 : TriggerState {
            internal State던전클리어2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004706, illust: "PuppetBunnyBlue_normal", duration: 3000,
                    script: "$02000545_BF__MAIN__25$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State던전클리어3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어3 : TriggerState {
            internal State던전클리어3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}