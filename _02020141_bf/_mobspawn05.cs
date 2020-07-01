namespace Maple2.Trigger._02020141_bf {
    public static class _mobspawn05 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State보스등장때까지잠시대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스등장때까지잠시대기 : TriggerState {
            internal State보스등장때까지잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State트리거영역체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거영역체크시작 : TriggerState {
            internal State트리거영역체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터등장대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터등장대기중 : TriggerState {
            internal State졸몬스터등장대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리거영역안플레이어최종체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거영역안플레이어최종체크 : TriggerState {
            internal State트리거영역안플레이어최종체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터등장하기(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State트리거영역체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터등장하기 : TriggerState {
            internal State졸몬스터등장하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {10501, 10502, 10503, 10504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리거영역에계속있는지체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거영역에계속있는지체크 : TriggerState {
            internal State트리거영역에계속있는지체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터리젠단계시작(context);
                }

                if (!context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터제거작동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠단계시작 : TriggerState {
            internal State졸몬스터리젠단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터리젠대기중(context);
                }

                if (!context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터제거작동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠대기중 : TriggerState {
            internal State졸몬스터리젠대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State졸몬스터제거작업(context);
                }

                if (!context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터제거작동대기(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new State졸몬스터리젠YesNo(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터리젠YesNo : TriggerState {
            internal State졸몬스터리젠YesNo(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State졸몬스터제거작업(context);
                }

                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터등장하기(context);
                }

                if (!context.UserDetected(arg1: new[] {10500})) {
                    return new State졸몬스터제거작동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터제거작동대기 : TriggerState {
            internal State졸몬스터제거작동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10500})) {
                    return new State트리거영역에계속있는지체크(context);
                }

                if (context.WaitTick(waitTick: 7000)) {
                    return new State졸몬스터제거작업(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸몬스터제거작업 : TriggerState {
            internal State졸몬스터제거작업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {10501, 10502, 10503, 10504});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리거영역체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}