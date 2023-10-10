namespace Maple2.Trigger._02000253_bf {
    public static class _move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
                context.SetEffect(triggerIds: new []{8041, 8042, 8043, 8044}, visible: false);
                context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 906) == 1) {
                    return new State벨라소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라소환 : TriggerState {
            internal State벨라소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동 : TriggerState {
            internal State벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom선택1 : TriggerState {
            internal StateRandom선택1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State1번(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new State2번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State3번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State4번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom선택11 : TriggerState {
            internal StateRandom선택11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State2번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State3번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State4번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom선택12 : TriggerState {
            internal StateRandom선택12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State1번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State3번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State4번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom선택13 : TriggerState {
            internal StateRandom선택13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State1번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State2번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State4번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom선택14 : TriggerState {
            internal StateRandom선택14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State1번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State2번(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new State3번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번 : TriggerState {
            internal State1번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetEffect(triggerIds: new []{8041}, visible: true);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904}, enabled: true);
                context.SetBreakable(triggerIds: new []{905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    return new State11번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11번 : TriggerState {
            internal State11번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8041}, visible: false);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.CreateMonster(spawnIds: new []{3001});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3001});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택11(context);
                }

                if (context.MonsterDead(spawnIds: new []{3001})) {
                    return new State12번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12번 : TriggerState {
            internal State12번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001052}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3001});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택11(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001052}, arg2: 0)) {
                    return new State끝1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번 : TriggerState {
            internal State2번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8042}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(timerId: "1", seconds: 10);
                context.SetBreakable(triggerIds: new []{905, 906, 907, 908, 1905, 1906, 1907, 1908, 2905, 2906, 2907, 2908, 3905, 3906, 3907, 3908}, enabled: true);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 909, 910, 911, 912, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    return new State21번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21번 : TriggerState {
            internal State21번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8042}, visible: false);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.CreateMonster(spawnIds: new []{3002});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3002});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택12(context);
                }

                if (context.MonsterDead(spawnIds: new []{3002})) {
                    return new State22번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22번 : TriggerState {
            internal State22번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001051}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3004});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택12(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001051}, arg2: 0)) {
                    return new State끝2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번 : TriggerState {
            internal State3번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8044}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(timerId: "1", seconds: 10);
                context.SetBreakable(triggerIds: new []{909, 910, 911, 912, 1909, 1910, 1911, 1912, 2909, 2910, 2911, 2912, 3909, 3910, 3911, 3912}, enabled: true);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 913, 914, 915, 916, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1913, 1914, 1915, 1916, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2913, 2914, 2915, 2916, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    return new State31번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State31번 : TriggerState {
            internal State31번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8044}, visible: false);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.CreateMonster(spawnIds: new []{3003});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3003});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택13(context);
                }

                if (context.MonsterDead(spawnIds: new []{3003})) {
                    return new State32번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State32번 : TriggerState {
            internal State32번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001050}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3004});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택13(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001050}, arg2: 0)) {
                    return new State끝3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번 : TriggerState {
            internal State4번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8043}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002523, textId: 20002523);
                context.SetTimer(timerId: "1", seconds: 10);
                context.SetBreakable(triggerIds: new []{913, 914, 915, 916, 1913, 1914, 1915, 1916, 2913, 2914, 2915, 2916, 3913, 3914, 3915, 3916}, enabled: true);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 2901, 2902, 2903, 2904, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 3901, 3902, 3903, 3904, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.HideGuideSummary(entityId: 20002523);
                    return new State41번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State41번 : TriggerState {
            internal State41번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8043}, visible: false);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.CreateMonster(spawnIds: new []{3004});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3004});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택14(context);
                }

                if (context.MonsterDead(spawnIds: new []{3004})) {
                    return new State42번(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State42번 : TriggerState {
            internal State42번(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001053}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{3004});
                    context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                    return new StateRandom선택14(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001053}, arg2: 0)) {
                    return new State끝4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝1 : TriggerState {
            internal State끝1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateRandom선택11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateRandom선택12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝3 : TriggerState {
            internal State끝3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateRandom선택13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝4 : TriggerState {
            internal State끝4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
                context.SetInteractObject(interactIds: new []{10001050, 10001051, 10001052, 10001053}, state: 2);
                context.SetBreakable(triggerIds: new []{901, 902, 903, 904, 1901, 1902, 1903, 1904, 2901, 2902, 2903, 2904, 3901, 3902, 3903, 3904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 2905, 2906, 2907, 2908, 2909, 2910, 2911, 2912, 2913, 2914, 2915, 2916, 3905, 3906, 3907, 3908, 3909, 3910, 3911, 3912, 3913, 3914, 3915, 3916}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateRandom선택14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
