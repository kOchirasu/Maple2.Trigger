using System;

namespace Maple2.Trigger._99999884 {
    public static class _scene01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {401}, arg2: false);
                context.SetEffect(arg1: new int[] {402}, arg2: false);
                context.SetEffect(arg1: new int[] {403}, arg2: false);
                context.SetEffect(arg1: new int[] {404}, arg2: false);
                context.SetActor(arg1: 405, arg2: false);
                context.SetEffect(arg1: new int[] {406}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
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
                    context.State = new State벨라등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라등장 : TriggerState {
            internal State벨라등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202});
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 4);
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
                context.SetEffect(arg1: new int[] {401}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$99999884__SCENE01__0$", arg4: 2);
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
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State프레이와오스칼등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이와오스칼등장 : TriggerState {
            internal State프레이와오스칼등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {204});
                context.SetEffect(arg1: new int[] {402}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State프레이대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사1 : TriggerState {
            internal State프레이대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11000119, arg3: "$99999884__SCENE01__2$", arg4: 2);
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
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEffect(arg1: new int[] {402}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__3$", arg4: 2);
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
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToDevorak");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__4$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State이펙트지연(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트지연 : TriggerState {
            internal State이펙트지연(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new int[] {402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State프레이대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사2 : TriggerState {
            internal State프레이대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.MoveNpc(arg1: 203, arg2: "203_MS2PatrolData_Frey_MoveToBella");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$99999884__SCENE01__5$", arg4: 2);
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
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new int[] {402}, arg2: false);
                context.SetEffect(arg1: new int[] {403}, arg2: true);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__6$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State프레이피격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이피격 : TriggerState {
            internal State프레이피격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 203, arg2: "203_MS2PatrolData_Frey_HitByBella");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State오스칼대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사1 : TriggerState {
            internal State오스칼대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.DestroyMonster(arg1: new int[] {203});
                context.SetEffect(arg1: new int[] {403}, arg2: false);
                context.SetEffect(arg1: new int[] {406}, arg2: true);
                context.SetActor(arg1: 405, arg2: true, arg3: "Down_Idle_A");
                context.MoveNpc(arg1: 204, arg2: "204_MS2PatrolData_Oskhal_MoveToFrey");
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$99999884__SCENE01__7$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State오스칼대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사2 : TriggerState {
            internal State오스칼대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$99999884__SCENE01__8$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State오스칼돌격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼돌격 : TriggerState {
            internal State오스칼돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 204, arg2: "204_MS2PatrolData_Oskhal_MoveToBella");
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new int[] {302}, arg2: 1);
                context.SetTimer(arg1: "1", arg2: 1);
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