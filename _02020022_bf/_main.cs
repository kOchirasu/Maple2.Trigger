using System;

namespace Maple2.Trigger._02020022_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State전투시작(context);

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 23200086, illustID: "Neirin_normal", msg: "$02020022_BF__main__0$",
                    duration: 5000, align: "left");
                context.AddCinematicTalk(npcID: 23200086, illustID: "Neirin_normal", msg: "$02020022_BF__main__1$",
                    duration: 5000, align: "left");
                context.AddCinematicTalk(npcID: 23200086, illustID: "Neirin_normal", msg: "$02020022_BF__main__2$",
                    duration: 5000, align: "left");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}