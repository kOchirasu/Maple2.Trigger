namespace Maple2.Trigger._02000356_bf {
    public static class _scene01 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201});
                context.SetEffect(arg1: new[] {401, 601, 602, 603, 604, 605, 606, 607, 608, 609}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SetSkillA") == 1) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State데보라크대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State데보라크대사 : TriggerState {
            internal State데보라크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 23000007, arg3: "$02000213_BF__SCENE01__0$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State레논등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논등장 : TriggerState {
            internal State레논등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203});
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State레논대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논대사1 : TriggerState {
            internal State레논대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000213_BF__SCENE01__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라등장 : TriggerState {
            internal State벨라등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202});
                context.SetEffect(arg1: new[] {401}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사1 : TriggerState {
            internal State벨라대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000213_BF__SCENE01__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000213_BF__SCENE01__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State알론등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론등장 : TriggerState {
            internal State알론등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204});
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State알론대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론대사1 : TriggerState {
            internal State알론대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$02000213_BF__SCENE01__4$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사3 : TriggerState {
            internal State벨라대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000213_BF__SCENE01__5$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사4 : TriggerState {
            internal State벨라대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000213_BF__SCENE01__6$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사5 : TriggerState {
            internal State벨라대사5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000213_BF__SCENE01__7$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라사라짐이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라사라짐이펙트 : TriggerState {
            internal State벨라사라짐이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {407}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라사라짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라사라짐 : TriggerState {
            internal State벨라사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {302}, arg2: true);
                context.DestroyMonster(arg1: new[] {202, 203, 204});
                context.CreateMonster(arg1: new[] {205});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State알론대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론대사2 : TriggerState {
            internal State알론대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$02000213_BF__SCENE01__8$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State알론대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론대사3 : TriggerState {
            internal State알론대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$02000213_BF__SCENE01__9$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State연출끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝 : TriggerState {
            internal State연출끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}