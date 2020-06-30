using System;

namespace Maple2.Trigger._99999931 {
    public static class _processlevel03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State레버당기기(context);

        private class State레버당기기 : TriggerState {
            internal State레버당기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000219}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000219}, arg2: 0)) {
                    context.State = new State카운트다운1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운1 : TriggerState {
            internal State카운트다운1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "3", arg3: new int[] {1000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State카운트다운2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운2 : TriggerState {
            internal State카운트다운2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "2", arg3: new int[] {1000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    context.State = new State카운트다운3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운3 : TriggerState {
            internal State카운트다운3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "1", arg3: new int[] {1000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State게임시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "34", arg2: 1);
                context.SetBreakable(
                    arg1: new int[] {
                        101, 102, 103, 104, 105, 106, 107, 112, 113, 115, 116, 118, 119, 121, 122, 124, 125, 130, 131,
                        132, 133, 134, 135, 136
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    context.State = new State게임진행1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임진행1 : TriggerState {
            internal State게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetBreakable(
                    arg1: new int[] {
                        101, 102, 103, 104, 105, 106, 107, 112, 113, 115, 116, 118, 119, 121, 122, 124, 125, 130, 131,
                        132, 133, 134, 135, 136
                    }, arg2: false);
                context.SetSkill(arg1: new int[] {801}, arg2: true);
                context.SetSkill(arg1: new int[] {802}, arg2: true);
                context.SetSkill(arg1: new int[] {803}, arg2: true);
                context.SetSkill(arg1: new int[] {804}, arg2: true);
                context.SetSkill(arg1: new int[] {805}, arg2: true);
                context.SetSkill(arg1: new int[] {806}, arg2: true);
                context.SetSkill(arg1: new int[] {807}, arg2: true);
                context.SetSkill(arg1: new int[] {812}, arg2: true);
                context.SetSkill(arg1: new int[] {813}, arg2: true);
                context.SetSkill(arg1: new int[] {815}, arg2: true);
                context.SetSkill(arg1: new int[] {816}, arg2: true);
                context.SetSkill(arg1: new int[] {818}, arg2: true);
                context.SetSkill(arg1: new int[] {819}, arg2: true);
                context.SetSkill(arg1: new int[] {821}, arg2: true);
                context.SetSkill(arg1: new int[] {822}, arg2: true);
                context.SetSkill(arg1: new int[] {824}, arg2: true);
                context.SetSkill(arg1: new int[] {825}, arg2: true);
                context.SetSkill(arg1: new int[] {830}, arg2: true);
                context.SetSkill(arg1: new int[] {831}, arg2: true);
                context.SetSkill(arg1: new int[] {832}, arg2: true);
                context.SetSkill(arg1: new int[] {833}, arg2: true);
                context.SetSkill(arg1: new int[] {834}, arg2: true);
                context.SetSkill(arg1: new int[] {835}, arg2: true);
                context.SetSkill(arg1: new int[] {836}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State게임진행2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임진행2 : TriggerState {
            internal State게임진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "36", arg2: 2);
                context.SetSkill(arg1: new int[] {801}, arg2: false);
                context.SetSkill(arg1: new int[] {802}, arg2: false);
                context.SetSkill(arg1: new int[] {803}, arg2: false);
                context.SetSkill(arg1: new int[] {804}, arg2: false);
                context.SetSkill(arg1: new int[] {805}, arg2: false);
                context.SetSkill(arg1: new int[] {806}, arg2: false);
                context.SetSkill(arg1: new int[] {807}, arg2: false);
                context.SetSkill(arg1: new int[] {812}, arg2: false);
                context.SetSkill(arg1: new int[] {813}, arg2: false);
                context.SetSkill(arg1: new int[] {815}, arg2: false);
                context.SetSkill(arg1: new int[] {816}, arg2: false);
                context.SetSkill(arg1: new int[] {818}, arg2: false);
                context.SetSkill(arg1: new int[] {819}, arg2: false);
                context.SetSkill(arg1: new int[] {821}, arg2: false);
                context.SetSkill(arg1: new int[] {822}, arg2: false);
                context.SetSkill(arg1: new int[] {824}, arg2: false);
                context.SetSkill(arg1: new int[] {825}, arg2: false);
                context.SetSkill(arg1: new int[] {830}, arg2: false);
                context.SetSkill(arg1: new int[] {831}, arg2: false);
                context.SetSkill(arg1: new int[] {832}, arg2: false);
                context.SetSkill(arg1: new int[] {833}, arg2: false);
                context.SetSkill(arg1: new int[] {834}, arg2: false);
                context.SetSkill(arg1: new int[] {835}, arg2: false);
                context.SetSkill(arg1: new int[] {836}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "36")) {
                    context.State = new State레버당기기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}