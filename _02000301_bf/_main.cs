namespace Maple2.Trigger._02000301_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000585}, arg2: 0);
                context.SetInteractObject(arg1: new[] {11000004, 13000006}, arg2: 2);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.CreateMonster(arg1: new[] {1007, 1008, 2099}, arg2: false);
                context.SetMesh(arg1: new[] {4998, 4999}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State트리스탄01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄01 : TriggerState {
            internal State트리스탄01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000252, arg3: "$02000301_BF__MAIN__0$", arg4: 4);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터전투 : TriggerState {
            internal State몬스터전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {1007, 1008})) {
                    context.State = new State골두스이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골두스이동 : TriggerState {
            internal State골두스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2099, arg2: "MS2PatrolData_2098");
                context.SetConversation(arg1: 1, arg2: 2099, arg3: "$02000301_BF__MAIN__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1007, 1008})) {
                    context.State = new State또다른연출시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {4998, 4999}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State또다른연출시작 : TriggerState {
            internal State또다른연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State골두스마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골두스마무리 : TriggerState {
            internal State골두스마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000252, arg3: "$02000301_BF__MAIN__2$", arg4: 4);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State또다른연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State또다른연출종료 : TriggerState {
            internal State또다른연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기 : TriggerState {
            internal State이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000585}, arg2: 1);
                context.ShowGuideSummary(entityId: 20002999, textId: 20002999);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.MoveNpc(arg1: 2099, arg2: "MS2PatrolData_2099");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000585}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002999);
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
                context.ShowCountUI(text: "$02000301_BF__MAIN__4$", stage: 1, count: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.MoveUser(arg1: 02000299, arg2: 2, arg3: 199);
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}