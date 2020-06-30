using System;
using System.Numerics;

namespace Maple2.Trigger._52020016_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 95, arg2: false, arg3: false);
                context.SetPortal(arg1: 96, arg2: false, arg3: false);
                context.SetEffect(
                    arg1: new int[] {
                        70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013,
                        70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024
                    }, arg2: false);
                context.SetMesh(arg1: new int[] {5001, 5002, 5003, 5004, 5005}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(
                    arg1: new int[]
                        {72001, 72002, 72003, 72004, 72005, 72006, 72007, 72008, 72009, 72010, 72011, 72012},
                    arg2: false);
                context.SetEffect(
                    arg1: new int[]
                        {73001, 73002, 73003, 73004, 73005, 73006, 73007, 73008, 73009, 73010, 73011, 73012},
                    arg2: false);
                context.SetMesh(arg1: new int[] {5103, 5104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    context.State = new State시작_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_2 : TriggerState {
            internal State시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new int[] {2000004}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작_2_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_2_2 : TriggerState {
            internal State시작_2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 0, arg3: "이곳은 뭐하는 곳이지?!", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 0, arg3: @"미카엘의 기운이 느껴지고 있어!\n서둘러야 해!!", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "시작_3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State시작_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_3 : TriggerState {
            internal State시작_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000004}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State시작_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_4 : TriggerState {
            internal State시작_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "한번 가볼까?", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State인트로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(0f, 0f, 0f));
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.SetPcEmotionLoop(arg1: "Stun_A", arg2: 1500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new State인트로_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_2 : TriggerState {
            internal State인트로_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 0, arg3: "???!!!", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 0, arg3: @"뭐야!!\n앞이 안보여!!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State인트로_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_3 : TriggerState {
            internal State인트로_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미카엘등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카엘등장 : TriggerState {
            internal State미카엘등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000001}, arg2: 0);
                context.CreateMonster(arg1: new int[] {300001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State미카엘_이동_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카엘_이동_1 : TriggerState {
            internal State미카엘_이동_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 300001, arg2: "MS2PatrolData0_300001_0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대화_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_1 : TriggerState {
            internal State대화_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 300001, arg3: "오호...여기까지 오다니...놀랍군요..", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 300001, arg3: "자...그럼 본격적으로 놀아볼까요?", arg4: 5);
                context.SetSkip(arg1: "카메라리셋_1");
                context.SetMesh(arg1: new int[] {5001, 5002, 5003, 5004, 5005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State카메라리셋_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_1 : TriggerState {
            internal State카메라리셋_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000001}, arg2: 1);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.DestroyMonster(arg1: new int[] {300001});
                context.SetEffect(
                    arg1: new int[] {
                        70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013,
                        70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이동_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_1 : TriggerState {
            internal State이동_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020016, arg2: 90);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투페이즈_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAmbientLight(arg1: new Vector3(180f, 180f, 149f));
                context.SetDirectionalLight(arg1: new Vector3(219f, 204f, 182f), arg2: new Vector3(219f, 204f, 182f));
                context.SetPortal(arg1: 95, arg2: true, arg3: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "갇혀 버렸어!", arg4: 3, arg5: 0);
            }
        }

        private class State전투페이즈_1 : TriggerState {
            internal State전투페이즈_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "미카엘이 조종하는 마리오네트 무리들을 처치하세요.", arg3: new int[] {4000});
                context.ShadowExpedition(type: "OpenBossGauge", maxGaugePoint: 300, title: "몬스터 처치 달성");
                context.SetUserValue(triggerID: 901, key: "respawn_phase_1", value: 1);
                context.SetUserValue(triggerID: 902, key: "respawn_phase_1", value: 1);
                context.SetUserValue(triggerID: 903, key: "respawn_phase_1", value: 1);
                context.SetUserValue(triggerID: 904, key: "respawn_phase_1", value: 1);
            }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 300)) {
                    context.State = new State페이즈_2_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이즈_2_준비 : TriggerState {
            internal State페이즈_2_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "CloseBossGauge");
                context.SetUserValue(triggerID: 901, key: "respawn_phase_1_end", value: 1);
                context.SetUserValue(triggerID: 902, key: "respawn_phase_1_end", value: 1);
                context.SetUserValue(triggerID: 903, key: "respawn_phase_1_end", value: 1);
                context.SetUserValue(triggerID: 904, key: "respawn_phase_1_end", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State불꺼짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼짐 : TriggerState {
            internal State불꺼짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 95, arg2: false, arg3: false);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(0f, 0f, 0f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State미카엘등장_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카엘등장_2 : TriggerState {
            internal State미카엘등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000002}, arg2: 0);
                context.CreateMonster(arg1: new int[] {300002}, arg2: false);
                context.MoveNpc(arg1: 300002, arg2: "MS2PatrolData0_300002_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대화_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_2 : TriggerState {
            internal State대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 300002, arg3: "음... 기대 이상인데요?", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 300002, arg3: "이번엔 이분들이 당신과 놀아줄겁니다!!", arg4: 5);
                context.MoveUser(arg1: 52020016, arg2: 91);
                context.SetSkip(arg1: "카메라리셋_2");
                context.SetMesh(arg1: new int[] {5103, 5104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statenpc등장연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc등장연출_1 : TriggerState {
            internal Statenpc등장연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {310001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statenpc등장연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc등장연출_2 : TriggerState {
            internal Statenpc등장연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {310002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statenpc등장연출_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc등장연출_3 : TriggerState {
            internal Statenpc등장연출_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {310003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statenpc등장연출_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc등장연출_4 : TriggerState {
            internal Statenpc등장연출_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {310004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라리셋_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_2 : TriggerState {
            internal State카메라리셋_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000002}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1600)) {
                    context.State = new State자기장생성(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }
        }

        private class State자기장생성 : TriggerState {
            internal State자기장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {300002});
                context.DestroyMonster(arg1: new int[] {310001});
                context.DestroyMonster(arg1: new int[] {310002});
                context.DestroyMonster(arg1: new int[] {310003});
                context.DestroyMonster(arg1: new int[] {310004});
                context.SetMesh(arg1: new int[] {5001, 5002, 5003, 5004, 5005}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(
                    arg1: new int[] {
                        70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013,
                        70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024
                    }, arg2: false);
                context.SetEffect(
                    arg1: new int[]
                        {72001, 72002, 72003, 72004, 72005, 72006, 72007, 72008, 72009, 72010, 72011, 72012},
                    arg2: true);
                context.SetEffect(
                    arg1: new int[]
                        {73001, 73002, 73003, 73004, 73005, 73006, 73007, 73008, 73009, 73010, 73011, 73012},
                    arg2: true);
                context.SetAmbientLight(arg1: new Vector3(180f, 180f, 149f));
                context.SetDirectionalLight(arg1: new Vector3(219f, 204f, 182f), arg2: new Vector3(219f, 204f, 182f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대화_놀람(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_놀람 : TriggerState {
            internal State대화_놀람(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "아앗! 오스칼과 레드아이, 알론... 그리고 레논?", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State몬스터등장_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2 : TriggerState {
            internal State몬스터등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 96, arg2: true, arg3: true);
                context.SetUserValue(triggerID: 905, key: "respawn_phase_2", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터등장_2_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2_2 : TriggerState {
            internal State몬스터등장_2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 906, key: "respawn_phase_2", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터등장_2_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2_3 : TriggerState {
            internal State몬스터등장_2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 907, key: "respawn_phase_2", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터등장_2_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2_4 : TriggerState {
            internal State몬스터등장_2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 908, key: "respawn_phase_2", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State몬스터사망_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_1 : TriggerState {
            internal State몬스터사망_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4000101})
                    && context.MonsterDead(arg1: new int[] {4000102})
                    && context.MonsterDead(arg1: new int[] {4000103})
                    && context.MonsterDead(arg1: new int[] {4000104})) {
                    context.State = new State시간종료_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시간종료_3 : TriggerState {
            internal State시간종료_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(193f, 180f, 137f), arg2: new Vector3(100f, 100f, 100f));
                context.SetConversation(arg1: 1, arg2: 0, arg3: "모두들...어디로 사라진거야?", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State불꺼짐_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불꺼짐_2 : TriggerState {
            internal State불꺼짐_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000003}, arg2: 0);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State몬스터등장_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetConversation(arg1: 2, arg2: 4000201, arg3: "자...기대하세요!", arg4: 5);
                context.SetSkip(arg1: "몬스터등장_3");
            }
        }

        private class State몬스터등장_3 : TriggerState {
            internal State몬스터등장_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new int[]
                        {72001, 72002, 72003, 72004, 72005, 72006, 72007, 72008, 72009, 72010, 72011, 72012},
                    arg2: false);
                context.SetMesh(arg1: new int[] {5104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "여기서 쓰러질 순 없어!", arg4: 3, arg5: 0);
                context.SetUserValue(triggerID: 909, key: "respawn_phase_3", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State카메라리셋_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_3 : TriggerState {
            internal State카메라리셋_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000003}, arg2: 1);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이동_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_3 : TriggerState {
            internal State이동_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "104")) {
                    context.State = new State이동_4(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAmbientLight(arg1: new Vector3(180f, 180f, 149f));
                context.SetDirectionalLight(arg1: new Vector3(219f, 204f, 182f), arg2: new Vector3(219f, 204f, 182f));
            }
        }

        private class State이동_4 : TriggerState {
            internal State이동_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new int[] {
                        70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013,
                        70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024
                    }, arg2: true);
                context.SetMesh(arg1: new int[] {5001, 5002, 5003, 5004, 5005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "아니! 이 녀석들은??!!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}