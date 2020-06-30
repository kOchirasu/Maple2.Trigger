using System;

namespace Maple2.Trigger._80000010_bonus {
    public static class _meso {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138,
                        139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "301")) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new int[] {201});
                context.CreateItem(arg1: new int[] {202});
                context.CreateItem(arg1: new int[] {203});
                context.CreateItem(arg1: new int[] {204});
                context.CreateItem(arg1: new int[] {205});
                context.CreateItem(arg1: new int[] {206});
                context.CreateItem(arg1: new int[] {207});
                context.CreateItem(arg1: new int[] {208});
                context.CreateItem(arg1: new int[] {209});
                context.CreateItem(arg1: new int[] {210});
                context.CreateItem(arg1: new int[] {211});
                context.CreateItem(arg1: new int[] {212});
                context.CreateItem(arg1: new int[] {213});
                context.CreateItem(arg1: new int[] {214});
                context.CreateItem(arg1: new int[] {215});
                context.CreateItem(arg1: new int[] {216});
                context.CreateItem(arg1: new int[] {217});
                context.CreateItem(arg1: new int[] {218});
                context.CreateItem(arg1: new int[] {219});
                context.CreateItem(arg1: new int[] {220});
                context.CreateItem(arg1: new int[] {221});
                context.CreateItem(arg1: new int[] {222});
                context.CreateItem(arg1: new int[] {223});
                context.CreateItem(arg1: new int[] {224});
                context.CreateItem(arg1: new int[] {225});
                context.CreateItem(arg1: new int[] {226});
                context.CreateItem(arg1: new int[] {227});
                context.CreateItem(arg1: new int[] {228});
                context.CreateItem(arg1: new int[] {229});
                context.CreateItem(arg1: new int[] {230});
                context.CreateItem(arg1: new int[] {231});
                context.CreateItem(arg1: new int[] {232});
                context.CreateItem(arg1: new int[] {233});
                context.CreateItem(arg1: new int[] {234});
                context.CreateItem(arg1: new int[] {235});
                context.CreateItem(arg1: new int[] {236});
                context.CreateItem(arg1: new int[] {237});
                context.CreateItem(arg1: new int[] {238});
                context.CreateItem(arg1: new int[] {239});
                context.CreateItem(arg1: new int[] {240});
                context.CreateItem(arg1: new int[] {241});
                context.CreateItem(arg1: new int[] {242});
                context.CreateItem(arg1: new int[] {243});
                context.CreateItem(arg1: new int[] {244});
                context.CreateItem(arg1: new int[] {245});
                context.CreateItem(arg1: new int[] {246});
                context.CreateItem(arg1: new int[] {247});
                context.CreateItem(arg1: new int[] {248});
                context.CreateItem(arg1: new int[] {249});
                context.CreateItem(arg1: new int[] {250});
                context.CreateItem(arg1: new int[] {251});
                context.CreateItem(arg1: new int[] {252});
                context.CreateItem(arg1: new int[] {253});
                context.CreateItem(arg1: new int[] {254});
                context.CreateItem(arg1: new int[] {255});
                context.CreateItem(arg1: new int[] {256});
                context.CreateItem(arg1: new int[] {257});
                context.CreateItem(arg1: new int[] {258});
                context.CreateItem(arg1: new int[] {259});
                context.CreateItem(arg1: new int[] {260});
                context.CreateItem(arg1: new int[] {261});
                context.CreateItem(arg1: new int[] {262});
                context.CreateItem(arg1: new int[] {263});
                context.CreateItem(arg1: new int[] {264});
                context.CreateItem(arg1: new int[] {265});
                context.CreateItem(arg1: new int[] {266});
                context.CreateItem(arg1: new int[] {267});
                context.CreateItem(arg1: new int[] {268});
                context.CreateItem(arg1: new int[] {269});
                context.CreateItem(arg1: new int[] {270});
                context.CreateItem(arg1: new int[] {9001, 9002, 9003, 9004, 9005});
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State완료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료2 : TriggerState {
            internal State완료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138,
                        139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154
                    }, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}