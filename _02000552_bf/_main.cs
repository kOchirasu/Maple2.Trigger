namespace Maple2.Trigger._02000552_bf {
    public static class _main {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State기본셋팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본셋팅 : TriggerState {
            internal State기본셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "NextPortal", value: 0);
                context.SetUserValue(key: "SmallRemove", value: 0);
                context.SetUserValue(key: "VacuumMessage", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State난이도체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23050003) {
                    return new State쉬운난이도보스등장(context);
                }

                if (context.GetDungeonId() == 23051003) {
                    return new State여려움난이도보스등장(context);
                }

                if (context.WaitTick(waitTick: 1100)) {
                    return new State여려움난이도보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State여려움난이도보스등장 : TriggerState {
            internal State여려움난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State보스전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉬운난이도보스등장 : TriggerState {
            internal State쉬운난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State보스전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스전투중 : TriggerState {
            internal State보스전투중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SmallRemove") == 1) {
                    return new State작아짐제거(context);
                }

                if (context.GetUserValue(key: "VacuumMessage") == 1) {
                    return new State메시지출력(context);
                }

                if (context.GetUserValue(key: "NextPortal") == 1) {
                    return new State다음이동포탈등장(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new State종료딜레이(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지출력 : TriggerState {
            internal State메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200008, textId: 29200008, duration: 6200);
                context.SetUserValue(key: "VacuumMessage", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State보스전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작아짐제거 : TriggerState {
            internal State작아짐제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {702}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.SetUserValue(key: "SmallRemove", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보스전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다음이동포탈등장 : TriggerState {
            internal State다음이동포탈등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.AddBuff(arg1: new[] {702}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.SetUserValue(key: "NextPortal", value: 0);
                context.SetUserValue(key: "SmallRemove", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State보스전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {702}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {702}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State클리어처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클리어처리 : TriggerState {
            internal State클리어처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}