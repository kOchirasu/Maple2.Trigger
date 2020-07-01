namespace Maple2.Trigger._52000021_qd {
    public static class _main01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000, 6100, 6200, 6201, 6202, 6300, 6301, 6400, 6401, 6500, 6600, 6700}, arg2: false);
                context.SetMesh(arg1: new[] {5000, 5001, 5002, 4000, 4001, 4002, 4003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 2);
                context.CreateMonster(arg1: new[] {111, 311}, arg2: true);
                context.MoveNpc(arg1: 311, arg2: "MS2PatrolData_311");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60001030}, arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 311});
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new[] {5000, 5001, 5002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.CameraSelect(arg1: 600, arg2: true);
                context.CreateMonster(arg1: new[] {101, 201, 301}, arg2: true);
                context.SetEffect(arg1: new[] {6200, 6300, 6201, 6301}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State카메라연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출시작 : TriggerState {
            internal State카메라연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 6);
                context.CameraSelectPath(arg1: new[] {600, 601, 602}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State이슈라대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화01 : TriggerState {
            internal State이슈라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State이슈라대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화02 : TriggerState {
            internal State이슈라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__1$", arg4: 5);
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State주문석반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주문석반응대기 : TriggerState {
            internal State주문석반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000831}, arg2: 0)) {
                    context.State = new State보호막설정01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000831}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 0);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State보호막설정01 : TriggerState {
            internal State보호막설정01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State목표전달01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목표전달01 : TriggerState {
            internal State목표전달01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State목표전달02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목표전달02 : TriggerState {
            internal State목표전달02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State유저감지01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지01 : TriggerState {
            internal State유저감지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State탈출경고01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고01 : TriggerState {
            internal State탈출경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__4$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State탈출경고02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고02 : TriggerState {
            internal State탈출경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 4);
                context.SetEffect(arg1: new[] {6400}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__5$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State탈출경고03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고03 : TriggerState {
            internal State탈출경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000021_QD__MAIN01__6$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State탈출경고04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고04 : TriggerState {
            internal State탈출경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 3);
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__7$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State탈출경고05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고05 : TriggerState {
            internal State탈출경고05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 3);
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__8$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    context.State = new State탈출경고06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출경고06 : TriggerState {
            internal State탈출경고06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000021_QD__MAIN01__9$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    context.State = new State탈출가능01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출가능01 : TriggerState {
            internal State탈출가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000832}, arg2: 0)) {
                    context.State = new State보호막해제01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000832}, arg2: 2);
            }
        }

        private class State보호막해제01 : TriggerState {
            internal State보호막해제01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
                context.SetEffect(arg1: new[] {6000, 6400, 6401}, arg2: false);
                context.SetEffect(arg1: new[] {6202}, arg2: true);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 610, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State홀슈타트연출01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6200, 6201, 6300, 6301, 6100}, arg2: false);
            }
        }

        private class State홀슈타트연출01 : TriggerState {
            internal State홀슈타트연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 2);
                context.SetEffect(arg1: new[] {6202}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__10$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State홀슈타트연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트연출02 : TriggerState {
            internal State홀슈타트연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 3);
                context.CameraSelect(arg1: 611, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9010, arg2: new[] {201})) {
                    context.State = new State홀슈타트연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트연출03 : TriggerState {
            internal State홀슈타트연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetEffect(arg1: new[] {6700, 6600, 6500}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000021_QD__MAIN01__11$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State홀슈타트연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트연출04 : TriggerState {
            internal State홀슈타트연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State연출종료준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료준비 : TriggerState {
            internal State연출종료준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "34", arg2: 2);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201, 101, 301});
                context.CreateMonster(arg1: new[] {111, 311}, arg2: true);
                context.MoveNpc(arg1: 311, arg2: "MS2PatrolData_311");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 611, arg2: false);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "EscapeHallstatt");
                context.SetMesh(arg1: new[] {5000, 5001, 5002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}