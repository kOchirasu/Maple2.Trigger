namespace Maple2.Trigger._02020130_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                        2017, 2018, 2019, 2020, 2021, 2022
                    }, arg2: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {600})) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {701, 702, 703}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703})) {
                    context.State = new State종료딜레이(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.GetDungeonState() == "Fail") {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.DungeonMissionComplete(missionId: 23040000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.DungeonClear();
                    context.SetAchievement(arg3: "IshuraFinalDungeonClear");
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 21, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 22, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 23, arg2: true, arg3: true, arg4: true);
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}