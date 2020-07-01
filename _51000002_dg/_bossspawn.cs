namespace Maple2.Trigger._51000002_dg {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new State보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020}, isVisible: true);
                context.ArcadeBoomBoomOceanStartGame(lifeCount: 20);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {99}, arg2: false);
                context.SetTimer(arg1: "6100", arg2: 6100);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State종료체크(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State종료체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {99});
            }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}