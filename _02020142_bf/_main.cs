using System;
using System.Numerics;

namespace Maple2.Trigger._02020142_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(45f, 21f, 28f));
                context.SetDirectionalLight(arg1: new Vector3(16f, 30f, 29f), arg2: new Vector3(130f, 130f, 130f));
                context.SetMesh(
                    arg1: new int[] {
                        901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919,
                        920, 921, 922, 923, 924
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {301}, arg2: true);
                context.SetUserValue(key: "1PhaseSpawnStart", value: 0);
                context.SetUserValue(key: "2PhaseSpawnStart", value: 0);
                context.SetPortal(arg1: 108, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 118, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 128, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 138, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 218, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 228, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 238, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 328, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 318, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 428, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 338, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 599, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 598, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new int[] {
                        949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967,
                        968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986,
                        987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999
                    }, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetUserValue(key: "TriggerMesh11", value: 99);
                context.SetUserValue(key: "TriggerMesh21", value: 99);
                context.SetUserValue(key: "TriggerMesh12", value: 99);
                context.SetUserValue(key: "TriggerMesh22", value: 99);
                context.SetUserValue(key: "TriggerMesh32", value: 99);
                context.SetUserValue(key: "TriggerMesh13", value: 99);
                context.SetUserValue(key: "TriggerMesh23", value: 99);
                context.SetUserValue(key: "TurkaTwoPhaseEnd", value: 99);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {99}, arg2: new int[] {10003330}, arg3: new byte[] {2})) {
                    context.State = new State이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {99}, arg2: new int[] {10003330}, arg3: new byte[] {3})) {
                    context.State = new State이동(context);
                    return;
                }

                if (context.UserDetected(arg1: "99")) {
                    context.State = new State연출용보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출용보스등장 : TriggerState {
            internal State연출용보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카대사연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카대사연출 : TriggerState {
            internal State투르카대사연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 23000120, illust: "Turka_normal", duration: 9000,
                    script: "$02020140_BF__PopUpCinema__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State1페이즈보스등장대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈보스등장대기 : TriggerState {
            internal State1페이즈보스등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "1PhaseSpawnStart", value: 1)) {
                    context.State = new State1페이즈보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈보스등장 : TriggerState {
            internal State1페이즈보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State1페이즈전투진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈전투진행 : TriggerState {
            internal State1페이즈전투진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 108, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "2PhaseSpawnStart", value: 1)) {
                    context.State = new State1페이즈전투완료_2페이즈투르카등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이즈전투완료_2페이즈투르카등장 : TriggerState {
            internal State1페이즈전투완료_2페이즈투르카등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.RemoveBuff(arg1: 98, arg2: 50004418);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State졸구간시작연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸구간시작연출딜레이 : TriggerState {
            internal State졸구간시작연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {301}, arg2: false);
                context.SetAmbientLight(arg1: new Vector3(255f, 140f, 172f));
                context.SetDirectionalLight(arg1: new Vector3(146f, 221f, 218f), arg2: new Vector3(130f, 130f, 130f));
                context.ChangeBackground(dds: "BG_Turka_A.dds");
            }

            public override void Execute() {
                if (context.UserValue(key: "StageOpen", value: 1)) {
                    context.State = new State최초졸구간몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State최초졸구간몬스터등장 : TriggerState {
            internal State최초졸구간몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh11", value: 0);
                context.SetUserValue(key: "TriggerMesh12", value: 0);
                context.SetUserValue(key: "TriggerMesh13", value: 0);
                context.CreateMonster(arg1: new int[] {1201, 1202, 1203, 1204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State졸구간본격진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸구간본격진행 : TriggerState {
            internal State졸구간본격진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 128, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸구간진행체크중 : TriggerState {
            internal State졸구간진행체크중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "TriggerMesh12", value: 0)) {
                    context.State = new State두번째가운데진행01(context);
                    return;
                }

                if (context.UserValue(key: "TriggerMesh22", value: 0)) {
                    context.State = new State세번째가운데진행01(context);
                    return;
                }

                if (context.UserValue(key: "TriggerMesh32", value: 0)) {
                    context.State = new State가운데지점보스방가는포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "2PhaseStartOk", value: 1)) {
                    context.State = new State모든졸구간지형과포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "TurkaTwoPhaseEnd", value: 1)) {
                    context.State = new State이맵에서진행끝내고다음맵으로이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째왼쪽진행01 : TriggerState {
            internal State두번째왼쪽진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh11", value: -1);
                context.SetUserValue(key: "TriggerMesh21", value: 0);
                context.CreateMonster(
                    arg1: new int[] {
                        2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116,
                        2117, 2118
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    context.State = new State두번째왼쪽진행02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째왼쪽진행02 : TriggerState {
            internal State두번째왼쪽진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 218, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째가운데진행01 : TriggerState {
            internal State두번째가운데진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh12", value: -1);
                context.SetUserValue(key: "TriggerMesh22", value: 0);
                context.CreateMonster(arg1: new int[] {2201, 2202, 2203, 2204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    context.State = new State두번째가운데진행02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째가운데진행02 : TriggerState {
            internal State두번째가운데진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 228, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째가운데진행01 : TriggerState {
            internal State세번째가운데진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh22", value: -1);
                context.SetUserValue(key: "TriggerMesh32", value: 0);
                context.CreateMonster(arg1: new int[] {3201, 3202, 3203, 3204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    context.State = new State세번째가운데진행02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째가운데진행02 : TriggerState {
            internal State세번째가운데진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 328, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째오른쪽진행01 : TriggerState {
            internal State두번째오른쪽진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh13", value: -1);
                context.SetUserValue(key: "TriggerMesh23", value: 0);
                context.CreateMonster(
                    arg1: new int[] {
                        2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316,
                        2317, 2318
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    context.State = new State두번째오른쪽진행02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째오른쪽진행02 : TriggerState {
            internal State두번째오른쪽진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 238, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽지점보스방가는포탈생성 : TriggerState {
            internal State왼쪽지점보스방가는포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh21", value: -1);
                context.SetPortal(arg1: 318, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2페이즈복격진행_안내메시지출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가운데지점보스방가는포탈생성 : TriggerState {
            internal State가운데지점보스방가는포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh32", value: -1);
                context.SetPortal(arg1: 428, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2페이즈복격진행_안내메시지출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오른쪽지점보스방가는포탈생성 : TriggerState {
            internal State오른쪽지점보스방가는포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh23", value: -1);
                context.SetPortal(arg1: 338, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2페이즈복격진행_안내메시지출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이즈복격진행_안내메시지출력 : TriggerState {
            internal State2페이즈복격진행_안내메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State모든졸구간지형과포탈생성 : TriggerState {
            internal State모든졸구간지형과포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "2PhaseStartOk", value: -1);
                context.SetPortal(arg1: 118, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 128, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 138, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 218, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 228, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 328, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 238, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 318, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 428, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 338, arg2: true, arg3: true, arg4: true);
                context.DestroyMonster(arg1: new int[] {
                    1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 2101, 2102,
                    2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118
                });
                context.DestroyMonster(arg1: new int[]
                    {1201, 1202, 1203, 1204, 2201, 2202, 2203, 2204, 3201, 3202, 3203, 3204});
                context.DestroyMonster(arg1: new int[] {
                    1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 2301, 2302, 2303,
                    2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318
                });
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State졸구간진행체크중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이맵에서진행끝내고다음맵으로이동 : TriggerState {
            internal State이맵에서진행끝내고다음맵으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 599, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 598, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 108, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State종료안내메시지_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료안내메시지_대기 : TriggerState {
            internal State종료안내메시지_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "97")) {
                    context.State = new State종료안내메시지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료안내메시지 : TriggerState {
            internal State종료안내메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {92}, arg2: true);
                context.DestroyMonster(arg1: new int[] {-1});
                context.ShowGuideSummary(entityID: 29200004, textID: 29200004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15500)) {
                    context.State = new State종료_메시지대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 29200004);
            }
        }

        private class State종료_메시지대기 : TriggerState {
            internal State종료_메시지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료안내메시지_다시출력_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료안내메시지_다시출력_대기 : TriggerState {
            internal State종료안내메시지_다시출력_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "97")) {
                    context.State = new State종료안내메시지_다시출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료안내메시지_다시출력 : TriggerState {
            internal State종료안내메시지_다시출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 29200004, textID: 29200004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15500)) {
                    context.State = new State종료_메시지대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 29200004);
            }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100304, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}