using System;

namespace Maple2.Trigger._99999922 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 99999, arg2: false);
                context.SetEffect(arg1: new int[] {100000001}, arg2: false);
                context.SetEffect(arg1: new int[] {100000002}, arg2: false);
                context.SetEffect(arg1: new int[] {100000003}, arg2: false);
                context.SetEffect(arg1: new int[] {100000004}, arg2: false);
                context.SetEffect(arg1: new int[] {100000005}, arg2: false);
                context.SetEffect(arg1: new int[] {100000006}, arg2: false);
                context.SetMesh(arg1: new int[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1400}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1500}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "1000001, 1000002, 1000003, 1000004, 1000005, 1000006", arg2: false);
                context.SetAgent(arg1: "1100001, 1100002, 1100003", arg2: false);
                context.SetInteractObject(arg1: new int[] {10000065}, arg2: 2);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1")) {
                    context.State = new State생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성_1 : TriggerState {
            internal State생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작_1 : TriggerState {
            internal State연출시작_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000001, arg2: true);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대화_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_1 : TriggerState {
            internal State대화_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 101, arg3: "신입사원인가요?", arg4: 5);
                context.SetSkip(arg1: "대화_1_스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대화_1_스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_1_스킵 : TriggerState {
            internal State대화_1_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대화_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_2 : TriggerState {
            internal State대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 101, arg3: @"반가워요.\n그럼 저를 따라와 보시겠어요??", arg4: 3);
                context.SetSkip(arg1: "연출끝_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대화_2_스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_2_스킵 : TriggerState {
            internal State대화_2_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출끝_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝_1 : TriggerState {
            internal State연출끝_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000001, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State돌사운드_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData0_101_1");
                context.SetMesh(arg1: new int[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, arg2: false,
                    arg3: 2000, arg4: 100, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111},
                    arg2: true, arg3: 5000, arg4: 100, arg5: 0f);
            }
        }

        private class State돌사운드_1 : TriggerState {
            internal State돌사운드_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "자경대장 오스칼과 함께 몬스터들을 처치하세요.", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State다리사운드_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {100000001}, arg2: true);
            }
        }

        private class State다리사운드_1 : TriggerState {
            internal State다리사운드_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State몬스터등장_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {100000002}, arg2: true);
            }
        }

        private class State몬스터등장_1 : TriggerState {
            internal State몬스터등장_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1400}, arg2: false, arg3: 1000, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State유저감지_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지_2 : TriggerState {
            internal State유저감지_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2", arg2: 0)) {
                    context.State = new State길막추가_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길막추가_1 : TriggerState {
            internal State길막추가_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "1000001, 1000002, 1000003, 1000004, 1000005, 1000006", arg2: true);
                context.SetMesh(arg1: new int[] {1400}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new Statenpc감지_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc감지_1 : TriggerState {
            internal Statenpc감지_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2", arg2: 0) && context.NpcDetected(arg1: 2, arg2: new int[] {101})) {
                    context.State = new State다리제거_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리제거_1 : TriggerState {
            internal State다리제거_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111},
                    arg2: false, arg3: 100, arg4: 100, arg5: 0f);
                context.SetEffect(arg1: new int[] {100000003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
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
                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new State3번째구역통로오픈(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "다리를 건너 마지막 몬스터를 처치하세요!", arg3: new int[] {4000});
            }
        }

        private class State3번째구역통로오픈 : TriggerState {
            internal State3번째구역통로오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "1000001, 1000002, 1000003, 1000004, 1000005, 1000006", arg2: false);
                context.SetMesh(arg1: new int[] {1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308}, arg2: false,
                    arg3: 2000, arg4: 100, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211},
                    arg2: true, arg3: 4000, arg4: 100, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State돌사운드_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {1500}, arg2: false, arg3: 5000, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData0_101_2");
            }
        }

        private class State돌사운드_2 : TriggerState {
            internal State돌사운드_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    context.State = new State다리사운드_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {100000004}, arg2: true);
            }
        }

        private class State다리사운드_2 : TriggerState {
            internal State다리사운드_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1900)) {
                    context.State = new State유저감지_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {100000005}, arg2: true);
            }
        }

        private class State유저감지_3 : TriggerState {
            internal State유저감지_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "3", arg2: 0) && context.NpcDetected(arg1: 3, arg2: new int[] {101})) {
                    context.State = new State길막추가_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길막추가_2 : TriggerState {
            internal State길막추가_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1500}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "1100001, 1100002, 1100003", arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State다리제거_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리제거_2 : TriggerState {
            internal State다리제거_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 99999, arg2: true);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211},
                    arg2: false, arg3: 100, arg4: 100, arg5: 0f);
                context.SetEffect(arg1: new int[] {100000006}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State몬스터사망_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_2 : TriggerState {
            internal State몬스터사망_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1002})) {
                    context.State = new State연출시작_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작_2 : TriggerState {
            internal State연출시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 99999, arg2: false);
                context.CameraSelect(arg1: 2000002, arg2: true);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State레버생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버생성_1 : TriggerState {
            internal State레버생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000065}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State대화_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_3 : TriggerState {
            internal State대화_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 101, arg3: "저 스위치를 당겨야해요!", arg4: 5);
                context.SetSkip(arg1: "대화_3_스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대화_3_스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화_3_스킵 : TriggerState {
            internal State대화_3_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출끝_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝_2 : TriggerState {
            internal State연출끝_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000002, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State레버생성_1_완료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "생성된 스위치를 작동시키세요!", arg3: new int[] {4000});
            }
        }

        private class State레버생성_1_완료 : TriggerState {
            internal State레버생성_1_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000065}, arg2: 0)) {
                    context.State = new State포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈생성 : TriggerState {
            internal State포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateNPC이동_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동_2 : TriggerState {
            internal StateNPC이동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData0_101_3");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "오예~끝났당~", arg4: 3, arg5: 7);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statenpc감지_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc감지_4 : TriggerState {
            internal Statenpc감지_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 4, arg2: new int[] {101})) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) { }
            }

            public override void OnExit() { }
        }
    }
}