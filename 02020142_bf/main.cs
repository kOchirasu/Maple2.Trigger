using System.Numerics;

namespace Maple2.Trigger._02020142_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(45f, 21f, 28f));
                context.SetDirectionalLight(arg1: new Vector3(16f, 30f, 29f), arg2: new Vector3(130f, 130f, 130f));
                context.SetMesh(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {301}, arg2: true);
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
                context.SetMesh(arg1: new[] {949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetUserValue(key: "TriggerMesh11", value: 99);
                context.SetUserValue(key: "TriggerMesh21", value: 99);
                context.SetUserValue(key: "TriggerMesh12", value: 99);
                context.SetUserValue(key: "TriggerMesh22", value: 99);
                context.SetUserValue(key: "TriggerMesh32", value: 99);
                context.SetUserValue(key: "TriggerMesh13", value: 99);
                context.SetUserValue(key: "TriggerMesh23", value: 99);
                context.SetUserValue(key: "TurkaTwoPhaseEnd", value: 99);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {99}, arg2: new[] {10003330}, arg3: new byte[] {2})) {
                    return new State이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {99}, arg2: new[] {10003330}, arg3: new byte[] {3})) {
                    return new State이동(context);
                }

                if (context.UserDetected(arg1: new[] {99})) {
                    return new StateCinematic용BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic용BossSpawn : TriggerState {
            internal StateCinematic용BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대사Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대사Cinematic : TriggerState {
            internal State투르카대사Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23000120, illust: "Turka_normal", duration: 9000, script: "$02020140_BF__PopUpCinema__0$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State1PhaseBossSpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1PhaseBossSpawnWait : TriggerState {
            internal State1PhaseBossSpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "1PhaseSpawnStart") == 1) {
                    return new State1PhaseBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1PhaseBossSpawn : TriggerState {
            internal State1PhaseBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State1Phase전투진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Phase전투진행 : TriggerState {
            internal State1Phase전투진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 108, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "2PhaseSpawnStart") == 1) {
                    return new State1Phase전투완료_2페이즈투르카Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Phase전투완료_2페이즈투르카Appear : TriggerState {
            internal State1Phase전투완료_2페이즈투르카Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.RemoveBuff(arg1: 98, arg2: 50004418);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State졸구간시작CinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸구간시작CinematicDelay : TriggerState {
            internal State졸구간시작CinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {301}, arg2: false);
                context.SetAmbientLight(arg1: new Vector3(255f, 140f, 172f));
                context.SetDirectionalLight(arg1: new Vector3(146f, 221f, 218f), arg2: new Vector3(130f, 130f, 130f));
                context.ChangeBackground(dds: "BG_Turka_A.dds");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StageOpen") == 1) {
                    return new State최초졸구간MonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State최초졸구간MonsterAppear : TriggerState {
            internal State최초졸구간MonsterAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh11", value: 0);
                context.SetUserValue(key: "TriggerMesh12", value: 0);
                context.SetUserValue(key: "TriggerMesh13", value: 0);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State졸구간본격진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸구간본격진행 : TriggerState {
            internal State졸구간본격진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 128, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸구간진행체크중 : TriggerState {
            internal State졸구간진행체크중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TriggerMesh12") == 0) {
                    return new State두번째가운데진행01(context);
                }

                if (context.GetUserValue(key: "TriggerMesh22") == 0) {
                    return new State세번째가운데진행01(context);
                }

                if (context.GetUserValue(key: "TriggerMesh32") == 0) {
                    return new State가운데지점Boss방가는PortalCreation(context);
                }

                if (context.GetUserValue(key: "2PhaseStartOk") == 1) {
                    return new State모든졸구간지형과PortalCreation(context);
                }

                if (context.GetUserValue(key: "TurkaTwoPhaseEnd") == 1) {
                    return new State이맵에서진행끝내고다음맵으로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째왼쪽진행01 : TriggerState {
            internal State두번째왼쪽진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh11", value: -1);
                context.SetUserValue(key: "TriggerMesh21", value: 0);
                context.CreateMonster(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    return new State두번째왼쪽진행02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째왼쪽진행02 : TriggerState {
            internal State두번째왼쪽진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 218, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째가운데진행01 : TriggerState {
            internal State두번째가운데진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh12", value: -1);
                context.SetUserValue(key: "TriggerMesh22", value: 0);
                context.CreateMonster(arg1: new[] {2201, 2202, 2203, 2204}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    return new State두번째가운데진행02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째가운데진행02 : TriggerState {
            internal State두번째가운데진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 228, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째가운데진행01 : TriggerState {
            internal State세번째가운데진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh22", value: -1);
                context.SetUserValue(key: "TriggerMesh32", value: 0);
                context.CreateMonster(arg1: new[] {3201, 3202, 3203, 3204}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    return new State세번째가운데진행02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째가운데진행02 : TriggerState {
            internal State세번째가운데진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 328, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째오른쪽진행01 : TriggerState {
            internal State두번째오른쪽진행01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh13", value: -1);
                context.SetUserValue(key: "TriggerMesh23", value: 0);
                context.CreateMonster(arg1: new[] {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3199)) {
                    return new State두번째오른쪽진행02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째오른쪽진행02 : TriggerState {
            internal State두번째오른쪽진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 238, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 799)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State왼쪽지점Boss방가는PortalCreation : TriggerState {
            internal State왼쪽지점Boss방가는PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh21", value: -1);
                context.SetPortal(arg1: 318, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2Phase복격진행_안내DisplayGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가운데지점Boss방가는PortalCreation : TriggerState {
            internal State가운데지점Boss방가는PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh32", value: -1);
                context.SetPortal(arg1: 428, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2Phase복격진행_안내DisplayGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오른쪽지점Boss방가는PortalCreation : TriggerState {
            internal State오른쪽지점Boss방가는PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "TriggerMesh23", value: -1);
                context.SetPortal(arg1: 338, arg2: true, arg3: true, arg4: true);
                context.SetAiExtraData(key: "TwoPhaseMainBattle", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2Phase복격진행_안내DisplayGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Phase복격진행_안내DisplayGuide : TriggerState {
            internal State2Phase복격진행_안내DisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모든졸구간지형과PortalCreation : TriggerState {
            internal State모든졸구간지형과PortalCreation(ITriggerContext context) : base(context) { }

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
                context.DestroyMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 1201, 1202, 1203, 1204, 2201, 2202, 2203, 2204, 3201, 3202, 3203, 3204, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State졸구간진행체크중(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEnd안내메시지_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내메시지_Wait : TriggerState {
            internal StateEnd안내메시지_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {97})) {
                    return new StateEnd안내메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내메시지 : TriggerState {
            internal StateEnd안내메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {92}, arg2: true);
                context.DestroyMonster(arg1: new[] {-1});
                context.ShowGuideSummary(entityId: 29200004, textId: 29200004);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15500)) {
                    return new StateEnd_메시지Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200004);
            }
        }

        private class StateEnd_메시지Wait : TriggerState {
            internal StateEnd_메시지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd안내메시지_다시출력_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내메시지_다시출력_Wait : TriggerState {
            internal StateEnd안내메시지_다시출력_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {97})) {
                    return new StateEnd안내메시지_다시출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내메시지_다시출력 : TriggerState {
            internal StateEnd안내메시지_다시출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200004, textId: 29200004);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15500)) {
                    return new StateEnd_메시지Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200004);
            }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100304, arg2: 1);
            }

            public override TriggerState Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}